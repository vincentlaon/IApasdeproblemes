using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1
{
    public partial class QCMForm : Form
    {
        
        

        public QCMForm()
        {
            InitializeComponent();
        }

        private void btn_abandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Questions_TextChanged(object sender, EventArgs e)
        {
            Question q1 = new Question("Enoncé 1", "A", "B", "C", "D", 0);
            txt_Questions.Text = q1.enonce;
            btn_repA.Text = q1.reponses[0];
            btn_repB.Text = q1.reponses[1];
            btn_repC.Text = q1.reponses[2];
            btn_repD.Text = q1.reponses[3];
        }

        
    }
}
