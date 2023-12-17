using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //BOTÃO DE LIMPAR
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control Controle in this.Controls)
            {
                if (Controle is TextBox)
                {
                    ((TextBox)Controle).Text = "";
                }
                this.Controls["label7"].Text = "SEM NOTA";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //BOTÃO DE CALCULAR
        private void button2_Click(object sender, EventArgs e)
        {
            float soma, media, valor;

            soma = 0;


            foreach(Control Controle in this.Controls) 
            {
                if (Controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)Controle).Text);
                    soma += valor;

                }
                media = soma / 5;
                this.Controls["label7"].Text = media.ToString();
            }
        }
    }
}
