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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewPanier = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAjoutRubrique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllArticlesFromRubriqueResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanier)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewRubriques
            // 
            this.treeViewRubriques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.treeViewRubriques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewRubriques.Location = new System.Drawing.Point(13, 25);
            this.treeViewRubriques.Name = "treeViewRubriques";
            this.treeViewRubriques.Size = new System.Drawing.Size(175, 308);
            this.treeViewRubriques.TabIndex = 2;
            this.treeViewRubriques.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRubriques_AfterSelect);
            // 
            // labelRubriques
            // 
            this.labelRubriques.AutoSize = true;
            this.labelRubriques.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRubriques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.labelRubriques.Location = new System.Drawing.Point(24, 9);
            this.labelRubriques.Name = "labelRubriques";
            this.labelRubriques.Size = new System.Drawing.Size(72, 13);
            this.labelRubriques.TabIndex = 3;
            this.labelRubriques.Text = "Rubriques :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.textBoxNom.Location = new System.Drawing.Point(68, 381);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(218, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.textBoxDesc.Location = new System.Drawing.Point(55, 58);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(218, 108);
            this.textBoxDesc.TabIndex = 6;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.labelNom.Location = new System.Drawing.Point(27, 384);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 7;
            this.labelNom.Text = "Nom :";
            // 
            // groupBoxAjoutRubrique
            // 
            this.groupBoxAjoutRubrique.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAjoutRubrique.Controls.Add(this.buttonCreerRubrique);
            this.groupBoxAjoutRubrique.Controls.Add(this.labelDesc);
            this.groupBoxAjoutRubrique.Controls.Add(this.textBoxDesc);
            this.groupBoxAjoutRubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAjoutRubrique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.groupBoxAjoutRubrique.Location = new System.Drawing.Point(13, 363);
            this.groupBoxAjoutRubrique.Name = "groupBoxAjoutRubrique";
            this.groupBoxAjoutRubrique.Size = new System.Drawing.Size(279, 206);
            this.groupBoxAjoutRubrique.TabIndex = 8;
            this.groupBoxAjoutRubrique.TabStop = false;
            this.groupBoxAjoutRubrique.Text = "Ajout de rubrique";
            // 
            // buttonCreerRubrique
            // 
            this.buttonCreerRubrique.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreerRubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreerRubrique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.buttonCreerRubrique.Location = new System.Drawing.Point(161, 172);
            this.buttonCreerRubrique.Name = "buttonCreerRubrique";
            this.buttonCreerRubrique.Size = new System.Drawing.Size(112, 28);
            this.buttonCreerRubrique.TabIndex = 9;
            this.buttonCreerRubrique.Text = "Créer la rubrique";
            this.buttonCreerRubrique.UseVisualStyleBackColor = false;
            this.buttonCreerRubrique.Click += new System.EventHandler(this.buttonCreerRubrique_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Articles :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewArticles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArticles.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewArticles.GridColor = System.Drawing.Color.BurlyWood;
            this.dataGridViewArticles.Location = new System.Drawing.Point(220, 25);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.RowHeadersVisible = false;
            this.dataGridViewArticles.Size = new System.Drawing.Size(528, 308);
            this.dataGridViewArticles.TabIndex = 11;
            this.dataGridViewArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticles_CellContentClick);
            this.dataGridViewArticles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticles_CellContentClick);
            // 
            // dataGridViewPanier
            // 
            this.dataGridViewPanier.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPanier.Location = new System.Drawing.Point(773, 25);
            this.dataGridViewPanier.Name = "dataGridViewPanier";
            this.dataGridViewPanier.RowHeadersVisible = false;
            this.dataGridViewPanier.Size = new System.Drawing.Size(595, 308);
            this.dataGridViewPanier.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(830, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Panier :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1342, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPanier);
            this.Controls.Add(this.dataGridViewArticles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelRubriques);
            this.Controls.Add(this.treeViewRubriques);
            this.Controls.Add(this.groupBoxAjoutRubrique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Application NTier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAjoutRubrique.ResumeLayout(false);
            this.groupBoxAjoutRubrique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllArticlesFromRubriqueResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataGridViewPanier;
        private System.Windows.Forms.Label label2;
    }
}