namespace ntier
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeViewRubriques = new System.Windows.Forms.TreeView();
            this.labelRubriques = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxAjoutRubrique = new System.Windows.Forms.GroupBox();
            this.buttonCreerRubrique = new System.Windows.Forms.Button();
            this.labelDesc = new System.Windows.Forms.Label();
            this.getAllArticlesFromRubriqueResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.groupBoxAjoutRubrique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllArticlesFromRubriqueResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer le pays";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(883, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeViewRubriques
            // 
            this.treeViewRubriques.Location = new System.Drawing.Point(13, 25);
            this.treeViewRubriques.Name = "treeViewRubriques";
            this.treeViewRubriques.Size = new System.Drawing.Size(279, 308);
            this.treeViewRubriques.TabIndex = 2;
            this.treeViewRubriques.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRubriques_AfterSelect);
            // 
            // labelRubriques
            // 
            this.labelRubriques.AutoSize = true;
            this.labelRubriques.Location = new System.Drawing.Point(9, 9);
            this.labelRubriques.Name = "labelRubriques";
            this.labelRubriques.Size = new System.Drawing.Size(61, 13);
            this.labelRubriques.TabIndex = 3;
            this.labelRubriques.Text = "Rubriques :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(68, 381);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(218, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(55, 58);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(218, 120);
            this.textBoxDesc.TabIndex = 6;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(27, 384);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 7;
            this.labelNom.Text = "Nom :";
            // 
            // groupBoxAjoutRubrique
            // 
            this.groupBoxAjoutRubrique.Controls.Add(this.buttonCreerRubrique);
            this.groupBoxAjoutRubrique.Controls.Add(this.labelDesc);
            this.groupBoxAjoutRubrique.Controls.Add(this.textBoxDesc);
            this.groupBoxAjoutRubrique.Location = new System.Drawing.Point(13, 356);
            this.groupBoxAjoutRubrique.Name = "groupBoxAjoutRubrique";
            this.groupBoxAjoutRubrique.Size = new System.Drawing.Size(279, 213);
            this.groupBoxAjoutRubrique.TabIndex = 8;
            this.groupBoxAjoutRubrique.TabStop = false;
            this.groupBoxAjoutRubrique.Text = "Ajout de rubrique";
            // 
            // buttonCreerRubrique
            // 
            this.buttonCreerRubrique.Location = new System.Drawing.Point(181, 184);
            this.buttonCreerRubrique.Name = "buttonCreerRubrique";
            this.buttonCreerRubrique.Size = new System.Drawing.Size(92, 21);
            this.buttonCreerRubrique.TabIndex = 9;
            this.buttonCreerRubrique.Text = "Créer la rubrique";
            this.buttonCreerRubrique.UseVisualStyleBackColor = true;
            this.buttonCreerRubrique.Click += new System.EventHandler(this.buttonCreerRubrique_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(11, 58);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(38, 13);
            this.labelDesc.TabIndex = 9;
            this.labelDesc.Text = "Desc :";
            // 
            // getAllArticlesFromRubriqueResponseBindingSource
            // 
            this.getAllArticlesFromRubriqueResponseBindingSource.DataSource = typeof(ntier.ServiceReference2.getAllArticlesFromRubriqueResponse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Articles :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Location = new System.Drawing.Point(313, 25);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.Size = new System.Drawing.Size(548, 308);
            this.dataGridViewArticles.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.dataGridViewArticles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelRubriques);
            this.Controls.Add(this.treeViewRubriques);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxAjoutRubrique);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAjoutRubrique.ResumeLayout(false);
            this.groupBoxAjoutRubrique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllArticlesFromRubriqueResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeViewRubriques;
        private System.Windows.Forms.Label labelRubriques;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.GroupBox groupBoxAjoutRubrique;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonCreerRubrique;
        private System.Windows.Forms.BindingSource getAllArticlesFromRubriqueResponseBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
    }
}