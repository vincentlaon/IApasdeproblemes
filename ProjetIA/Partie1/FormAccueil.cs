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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void btn_QCM_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; //On regarde si le sender est bien un bouton. Si non --> Valeur null. 
            if (btn != null)
            {
                QCMForm qf = new QCMForm();
                qf.Show();
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         If Me._DataSet.Table.Contrat = "True" then
             Me.Button_AddListBox.BackColor = Drawing.Color.Red
        elseif Me._DataSet.Table.Contrat = "False" then 
             Me.Button_AddListBox.BackColor = Drawing.Color.Green
        */
    }
}
