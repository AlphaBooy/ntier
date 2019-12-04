using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntier
{


    public partial class Form1 : Form
    {
        public const int NUMERO_CLIENT = 1;

        ServiceReference2.WebService2SoapClient client;
        private ServiceReference2.CRubrique selectedNode;

        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference2.WebService2SoapClient();
            selectedNode = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getRubriques(treeViewRubriques.Nodes.Add("Rubriques"), null, client.getAllRubrique());
            displayPanier();
        }

        public void getRubriques(TreeNode node, Nullable<int> idRubrique, ServiceReference2.CRubrique[] listRubriques)
        {
            foreach (ServiceReference2.CRubrique element in listRubriques)
            {
                TreeNode NoeudFils = new TreeNode(element.Nom);
                NoeudFils.Tag = element;
                node.Nodes.Add(NoeudFils);
                getRubriques(NoeudFils, element.Id, element.RubriquesFilles);
            }
        }

        private void treeViewRubriques_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ServiceReference2.CRubrique selectedNode = (ServiceReference2.CRubrique)e.Node.Tag;
            if (selectedNode != null)
            displayArticles(selectedNode);
        }

        private void buttonCreerRubrique_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text == null || textBoxNom.Text == "")
            {
                MessageBox.Show("Veuillez renseigner le nom du pays !");
            }
            else
            {
                if (selectedNode == null)
                {
                    client.createRubriqueAsync(textBoxNom.Text, textBoxDesc.Text, null);
                } else
                {
                    client.createRubriqueAsync(textBoxNom.Text, textBoxDesc.Text, selectedNode);
                }
            }
        }

        

        private void displayArticles(ServiceReference2.CRubrique rubrique)
        {
            ServiceReference2.CArticle[] listArticle = client.getAllArticlesFromRubrique(rubrique.Id);

            DataTable dtArticle = new DataTable();
            dtArticle.Columns.Add("Nom");
            dtArticle.Columns.Add("Description");
            dtArticle.Columns.Add("Prix Unitaire");
            dtArticle.Columns.Add("Poids");
            dtArticle.Columns.Add("Articles en stock");

            foreach (ServiceReference2.CArticle element in listArticle)
            {
                DataRow dr = dtArticle.NewRow();
                dr["Nom"] = element.Nom;
                dr["Description"] = element.Description;
                dr["Prix Unitaire"] = element.Prix_unitaire;
                dr["Poids"] = element.Poids;
                dr["Articles en stock"] = element.Quantite_stock;
                dtArticle.Rows.Add(dr);
            }
            dataGridViewArticles.DataSource = dtArticle;
        }

        private void displayPanier()
        {
            ServiceReference2.CLignePanier[] panier = client.getAllLignePanierFromClient(NUMERO_CLIENT);

            DataTable dtPanier = new DataTable();
            dtPanier.Columns.Add("Nom");
            dtPanier.Columns.Add("Description");
            dtPanier.Columns.Add("Prix Unitaire");
            dtPanier.Columns.Add("Poids");
            dtPanier.Columns.Add("Articles en stock");
            dtPanier.Columns.Add("Quantité");

            foreach (ServiceReference2.CLignePanier element in panier)
            {
                ServiceReference2.CArticle article = client.findArticle(element.Id_Article);

                DataRow dr = dtPanier.NewRow();
                dr["Nom"] = article.Nom;
                dr["Description"] = article.Description;
                dr["Prix Unitaire"] = article.Prix_unitaire;
                dr["Poids"] = article.Poids;
                dr["Articles en stock"] = article.Quantite_stock;
                dr["Quantité"] = element.Quantite;
                dtPanier.Rows.Add(dr);
            }
            dataGridViewPanier.DataSource = dtPanier;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewArticles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            client.ajoutLignePanier(NUMERO_CLIENT,((ServiceReference2.CArticle)dataGridViewArticles.CurrentRow.DataBoundItem).Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}