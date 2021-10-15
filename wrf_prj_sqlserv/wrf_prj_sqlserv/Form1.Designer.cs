namespace wrf_prj_sqlserv
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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.btConnect = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lvListeClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.gbAfficher = new System.Windows.Forms.GroupBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.btAjout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAjout = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdAdd = new System.Windows.Forms.TextBox();
            this.gbAfficher.SuspendLayout();
            this.gbAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(463, 6);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(156, 73);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Rechercher";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(83, 20);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(164, 22);
            this.tbID.TabIndex = 2;
            // 
            // lvListeClient
            // 
            this.lvListeClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvListeClient.HideSelection = false;
            this.lvListeClient.Location = new System.Drawing.Point(1, 122);
            this.lvListeClient.Name = "lvListeClient";
            this.lvListeClient.Size = new System.Drawing.Size(618, 223);
            this.lvListeClient.TabIndex = 3;
            this.lvListeClient.UseCompatibleStateImageBehavior = false;
            this.lvListeClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nom";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "prenom";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "adresse";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "cp";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "entrer l\'id :";
            // 
            // gbAfficher
            // 
            this.gbAfficher.Controls.Add(this.label1);
            this.gbAfficher.Controls.Add(this.lvListeClient);
            this.gbAfficher.Controls.Add(this.tbID);
            this.gbAfficher.Controls.Add(this.btConnect);
            this.gbAfficher.Location = new System.Drawing.Point(40, 38);
            this.gbAfficher.Name = "gbAfficher";
            this.gbAfficher.Size = new System.Drawing.Size(695, 376);
            this.gbAfficher.TabIndex = 5;
            this.gbAfficher.TabStop = false;
            this.gbAfficher.Text = "Afficher un client";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(104, 45);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(155, 22);
            this.tbNom.TabIndex = 6;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(104, 82);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(155, 22);
            this.tbPrenom.TabIndex = 7;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(104, 132);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(155, 22);
            this.tbAdresse.TabIndex = 8;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(104, 187);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(155, 22);
            this.tbCP.TabIndex = 9;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(104, 231);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(155, 22);
            this.tbVille.TabIndex = 10;
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(118, 275);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(129, 53);
            this.btAjout.TabIndex = 5;
            this.btAjout.Text = "Ajouter";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "prenom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "cp :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ville:";
            // 
            // gbAjout
            // 
            this.gbAjout.Controls.Add(this.label7);
            this.gbAjout.Controls.Add(this.tbIdAdd);
            this.gbAjout.Controls.Add(this.label6);
            this.gbAjout.Controls.Add(this.label5);
            this.gbAjout.Controls.Add(this.label4);
            this.gbAjout.Controls.Add(this.label3);
            this.gbAjout.Controls.Add(this.label2);
            this.gbAjout.Controls.Add(this.btAjout);
            this.gbAjout.Controls.Add(this.tbVille);
            this.gbAjout.Controls.Add(this.tbCP);
            this.gbAjout.Controls.Add(this.tbAdresse);
            this.gbAjout.Controls.Add(this.tbPrenom);
            this.gbAjout.Controls.Add(this.tbNom);
            this.gbAjout.Location = new System.Drawing.Point(763, 38);
            this.gbAjout.Name = "gbAjout";
            this.gbAjout.Size = new System.Drawing.Size(282, 344);
            this.gbAjout.TabIndex = 15;
            this.gbAjout.TabStop = false;
            this.gbAjout.Text = "Ajouter un client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "id : ";
            // 
            // tbIdAdd
            // 
            this.tbIdAdd.Location = new System.Drawing.Point(104, 15);
            this.tbIdAdd.Name = "tbIdAdd";
            this.tbIdAdd.Size = new System.Drawing.Size(155, 22);
            this.tbIdAdd.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.gbAjout);
            this.Controls.Add(this.gbAfficher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAfficher.ResumeLayout(false);
            this.gbAfficher.PerformLayout();
            this.gbAjout.ResumeLayout(false);
            this.gbAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ListView lvListeClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAfficher;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbAjout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdAdd;
    }
}

