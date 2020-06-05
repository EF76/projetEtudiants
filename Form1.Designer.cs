namespace GestionDesEtudiants
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnRaf = new System.Windows.Forms.Button();
            this.lstEtudiants = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(513, 63);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(205, 45);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter un nouvel étudiant";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(513, 141);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(205, 45);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modifier l\'étudiant sélectionné";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(513, 211);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(205, 45);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer l\'étudiant sélectionné";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnRaf
            // 
            this.btnRaf.Location = new System.Drawing.Point(513, 299);
            this.btnRaf.Name = "btnRaf";
            this.btnRaf.Size = new System.Drawing.Size(205, 45);
            this.btnRaf.TabIndex = 4;
            this.btnRaf.Text = "Rafraichir la Liste";
            this.btnRaf.UseVisualStyleBackColor = true;
            this.btnRaf.Click += new System.EventHandler(this.btnRaf_Click);
            // 
            // lstEtudiants
            // 
            this.lstEtudiants.FormattingEnabled = true;
            this.lstEtudiants.Location = new System.Drawing.Point(60, 63);
            this.lstEtudiants.Name = "lstEtudiants";
            this.lstEtudiants.Size = new System.Drawing.Size(274, 316);
            this.lstEtudiants.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEtudiants);
            this.Controls.Add(this.btnRaf);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjouter);
            this.Name = "Form1";
            this.Text = "Gestion des Etudiants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnRaf;
        private System.Windows.Forms.ListBox lstEtudiants;
    }
}

