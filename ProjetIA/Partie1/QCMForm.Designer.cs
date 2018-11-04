namespace Partie1
{
    partial class QCMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Questions = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_repA = new System.Windows.Forms.Button();
            this.btn_repB = new System.Windows.Forms.Button();
            this.btn_repC = new System.Windows.Forms.Button();
            this.btn_repD = new System.Windows.Forms.Button();
            this.lbl_numQuestion = new System.Windows.Forms.Label();
            this.txt_annonceScore = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_abandon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Questions
            // 
            this.txt_Questions.Location = new System.Drawing.Point(61, 93);
            this.txt_Questions.Multiline = true;
            this.txt_Questions.Name = "txt_Questions";
            this.txt_Questions.Size = new System.Drawing.Size(411, 72);
            this.txt_Questions.TabIndex = 1;
            this.txt_Questions.TextChanged += new System.EventHandler(this.txt_Questions_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.Location = new System.Drawing.Point(133, 30);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(215, 39);
            this.lbl_question.TabIndex = 3;
            this.lbl_question.Text = "Question N°";
            // 
            // btn_repA
            // 
            this.btn_repA.Location = new System.Drawing.Point(61, 181);
            this.btn_repA.Name = "btn_repA";
            this.btn_repA.Size = new System.Drawing.Size(411, 46);
            this.btn_repA.TabIndex = 4;
            this.btn_repA.Text = "Réponse A";
            this.btn_repA.UseVisualStyleBackColor = true;
            // 
            // btn_repB
            // 
            this.btn_repB.Location = new System.Drawing.Point(148, 247);
            this.btn_repB.Name = "btn_repB";
            this.btn_repB.Size = new System.Drawing.Size(237, 46);
            this.btn_repB.TabIndex = 5;
            this.btn_repB.Text = "Réponse B";
            this.btn_repB.UseVisualStyleBackColor = true;
            // 
            // btn_repC
            // 
            this.btn_repC.Location = new System.Drawing.Point(148, 308);
            this.btn_repC.Name = "btn_repC";
            this.btn_repC.Size = new System.Drawing.Size(237, 46);
            this.btn_repC.TabIndex = 6;
            this.btn_repC.Text = "Réponse C";
            this.btn_repC.UseVisualStyleBackColor = true;
            // 
            // btn_repD
            // 
            this.btn_repD.Location = new System.Drawing.Point(148, 370);
            this.btn_repD.Name = "btn_repD";
            this.btn_repD.Size = new System.Drawing.Size(237, 46);
            this.btn_repD.TabIndex = 7;
            this.btn_repD.Text = "Réponse D";
            this.btn_repD.UseVisualStyleBackColor = true;
            // 
            // lbl_numQuestion
            // 
            this.lbl_numQuestion.AutoSize = true;
            this.lbl_numQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numQuestion.Location = new System.Drawing.Point(344, 30);
            this.lbl_numQuestion.Name = "lbl_numQuestion";
            this.lbl_numQuestion.Size = new System.Drawing.Size(41, 39);
            this.lbl_numQuestion.TabIndex = 8;
            this.lbl_numQuestion.Text = "X";
            // 
            // txt_annonceScore
            // 
            this.txt_annonceScore.AutoSize = true;
            this.txt_annonceScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_annonceScore.Location = new System.Drawing.Point(55, 451);
            this.txt_annonceScore.Name = "txt_annonceScore";
            this.txt_annonceScore.Size = new System.Drawing.Size(269, 31);
            this.txt_annonceScore.TabIndex = 9;
            this.txt_annonceScore.Text = "Votre score est de :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(330, 445);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(41, 39);
            this.lbl_score.TabIndex = 10;
            this.lbl_score.Text = "X";
            // 
            // btn_abandon
            // 
            this.btn_abandon.Location = new System.Drawing.Point(462, 507);
            this.btn_abandon.Name = "btn_abandon";
            this.btn_abandon.Size = new System.Drawing.Size(87, 26);
            this.btn_abandon.TabIndex = 11;
            this.btn_abandon.Text = "Abandonner";
            this.btn_abandon.UseVisualStyleBackColor = true;
            this.btn_abandon.Click += new System.EventHandler(this.btn_abandon_Click);
            // 
            // QCMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 545);
            this.Controls.Add(this.btn_abandon);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.txt_annonceScore);
            this.Controls.Add(this.lbl_numQuestion);
            this.Controls.Add(this.btn_repD);
            this.Controls.Add(this.btn_repC);
            this.Controls.Add(this.btn_repB);
            this.Controls.Add(this.btn_repA);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.txt_Questions);
            this.Name = "QCMForm";
            this.Text = "Bienvenue sur le QCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Questions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_repA;
        private System.Windows.Forms.Button btn_repB;
        private System.Windows.Forms.Button btn_repC;
        private System.Windows.Forms.Button btn_repD;
        private System.Windows.Forms.Label lbl_numQuestion;
        private System.Windows.Forms.Label txt_annonceScore;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_abandon;
    }
}