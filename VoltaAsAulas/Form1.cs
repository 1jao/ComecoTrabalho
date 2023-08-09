using System;
using System.Windows.Forms;

namespace VoltaAsAulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string numero = TxtNum.Text;
            string cartao = TxtCard.Text;

            MessageBox.Show(

                "nome:" + name +
                "\nNúmero" + numero +
                "\nnúmero cartão" + cartao, 

                "Infos:"
                ,

                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                
                
                );



        }
    }
}
