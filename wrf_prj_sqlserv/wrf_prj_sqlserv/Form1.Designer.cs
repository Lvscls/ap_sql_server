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
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(503, 44);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(156, 73);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Rechercher";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(41, 57);
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
            this.lvListeClient.Location = new System.Drawing.Point(41, 160);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvListeClient);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

