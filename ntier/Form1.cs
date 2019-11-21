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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Veuillez renseigner le nom du pays !");
            }
            else
            {
                client.createPaysAsync(textBox1.Text);
            }
            //client.HelloWorld1Completed += Client_HelloWorld1Completed;
            //client.HelloWorld1Async();
        }

        //private void Client_HelloWorld1Completed(object sender, ServiceReference1.HelloWorld1CompletedEventArgs e)
        //{
        //    MessageBox.Show(e.Result);
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeViewRubriques_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ServiceReference2.CRubrique selectedNode = (ServiceReference2.CRubrique)e.Node.Tag;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}