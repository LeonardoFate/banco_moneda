using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSolicitar.Enabled = false;
        }
        private void controlBtn()
        {
            if (txtName.Text.Trim() != String.Empty && txtName.Text.All(Char.IsLetter))
            {
                btnSolicitar.Enabled = true;
                errorProvider1.SetError(txtName, "");
            }
            else
            {
                if (!(txtName.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(txtName,"El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtName, "Introduzca un Nombre");
                }
                btnSolicitar.Enabled = false;
                txtName.Focus();
            }
        } 
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            controlBtn();
        }
    }
}
