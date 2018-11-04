namespace Partie1
{
    partial class FormAccueil
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_explication1 = new System.Windows.Forms.Label();
            this.lbl_demandeChoix = new System.Windows.Forms.Label();
            this.lbl_QCM = new System.Windows.Forms.Label();
            this.lbl_Dijkstra = new System.Windows.Forms.Label();
            this.btn_QCM = new System.Windows.Forms.Button();
            this.btn_Dijkstra = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(44, 22);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(615, 157);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Bonjour et bienvenue sur l\'application : \"IApasdeproblèmes\" ! ";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_explication1
            // 
            this.lbl_explication1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_explication1.Location = new System.Drawing.Point(95, 197);
            this.lbl_explication1.Name = "lbl_explication1";
            this.lbl_explication1.Size = new System.Drawing.Size(528, 79);
            this.lbl_explication1.TabIndex = 1;
            this.lbl_explication1.Text = "Venez tester vos connaissances en Intelligence Artificielle de manière ludique ! " +
    "";
            this.lbl_explication1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_demandeChoix
            // 
            this.lbl_demandeChoix.AutoSize = true;
            this.lbl_demandeChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demandeChoix.Location = new System.Drawing.Point(171, 298);
            this.lbl_demandeChoix.Name = "lbl_demandeChoix";
            this.lbl_demandeChoix.Size = new System.Drawing.Size(354, 20);
            this.lbl_demandeChoix.TabIndex = 2;
            this.lbl_demandeChoix.Text = "Choisissez le sujet que vous souhaitez travailler : ";
            // 
            // lbl_QCM
            // 
            this.lbl_QCM.AutoSize = true;
            this.lbl_QCM.Location = new System.Drawing.Point(239, 334);
            this.lbl_QCM.Name = "lbl_QCM";
            this.lbl_QCM.Size = new System.Drawing.Size(124, 13);
            this.lbl_QCM.TabIndex = 3;
            this.lbl_QCM.Text = "- QCM sur l\'IA en général";
            // 
            // lbl_Dijkstra
            // 
            this.lbl_Dijkstra.AutoSize = true;
            this.lbl_Dijkstra.Location = new System.Drawing.Point(239, 375);
            this.lbl_Dijkstra.Name = "lbl_Dijkstra";
            this.lbl_Dijkstra.Size = new System.Drawing.Size(235, 13);
            this.lbl_Dijkstra.TabIndex = 4;
            this.lbl_Dijkstra.Text = "- Questions specifiques à l\'allgorithme de Dijkstra";
            // 
            // btn_QCM
            // 
            this.btn_QCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QCM.Location = new System.Drawing.Point(52, 448);
            this.btn_QCM.Name = "btn_QCM";
            this.btn_QCM.Size = new System.Drawing.Size(223, 86);
            this.btn_QCM.TabIndex = 5;
            this.btn_QCM.Text = "QCM";
            this.btn_QCM.UseVisualStyleBackColor = true;
            this.btn_QCM.Click += new System.EventHandler(this.btn_QCM_Click);
            // 
            // btn_Dijkstra
            // 
            this.btn_Dijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dijkstra.Location = new System.Drawing.Point(400, 448);
            this.btn_Dijkstra.Name = "btn_Dijkstra";
            this.btn_Dijkstra.Size = new System.Drawing.Size(223, 86);
            this.btn_Dijkstra.TabIndex = 6;
            this.btn_Dijkstra.Text = "Dijkstra";
            this.btn_Dijkstra.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(276, 578);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(124, 45);
            this.btn_Quit.TabIndex = 7;
            this.btn_Quit.Text = "Quitter";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 637);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Dijkstra);
            this.Controls.Add(this.btn_QCM);
            this.Controls.Add(this.lbl_Dijkstra);
            this.Controls.Add(this.lbl_QCM);
            this.Controls.Add(this.lbl_demandeChoix);
            this.Controls.Add(this.lbl_explication1);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FormAccueil";
            this.Text = "Tester vos connaissances en Intelligence Artificielle !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_explication1;
        private System.Windows.Forms.Label lbl_demandeChoix;
        private System.Windows.Forms.Label lbl_QCM;
        private System.Windows.Forms.Label lbl_Dijkstra;
        private System.Windows.Forms.Button btn_QCM;
        private System.Windows.Forms.Button btn_Dijkstra;
        private System.Windows.Forms.Button btn_Quit;
    }
}

