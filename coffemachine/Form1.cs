using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffemachine
{


    public partial class Form1 : Form
    {

        PictureBox[] fotos = new PictureBox[9];
        Label[] rotulo = new Label[9];
        Image fotoPic = null;
        Double[] preco = new double[9];
        double total = 0;

        


        public Form1()
        {
            InitializeComponent();
        }

        private void lbpreco1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            consulta();
        }

        private void consulta()
        {
            

            associa();

            conexao comb = new conexao();

            comb.sql = "Select * from tb01_produtos where tb01_cod between 1 and 17 order by tb01_nome";
            
            comb.open();
            int ind = 0;

            MySqlDataReader dados = comb.Execsql();

            if(dados.HasRows)
            {
                while(dados.Read())
                {
                    rotulo[ind].Text = Convert.ToDouble(dados["tb01_preco"]).ToString("c2");
                    preco[ind] = Convert.ToDouble( dados["tb01_preco"]);
                    byte[] foto = (byte[])dados["tb01_imagem"];
                    MemoryStream ms = new MemoryStream(foto);
                    fotoPic = Image.FromStream(ms);
                    fotos[ind].SizeMode = PictureBoxSizeMode.StretchImage;
                    fotos[ind].Image = fotoPic;
                    ind++;
               
                }

                comb.close();

            }


        }

        private void associa()
        {
            fotos[0] = pb1;
            fotos[1] = pb2;
            fotos[2] = pb3;
            fotos[3] = pb4;
            fotos[4] = pb5;
            fotos[5] = pb6;
            fotos[6] = pb7;
            fotos[7] = pb8;
            fotos[8] = pb9;

            rotulo[0] = lbpreco1;
            rotulo[1] = lbpreco2;
            rotulo[2] = lbpreco3;
            rotulo[3] = lbpreco4;
            rotulo[4] = lbpreco5;
            rotulo[5] = lbpreco6;
            rotulo[6] = lbpreco7;
            rotulo[7] = lbpreco8;
            rotulo[8] = lbpreco9;



        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            if (total > preco[2])
            {
                lb_troco.Text = (total - preco[2]).ToString("c2");
                imagem_troco.Image = pb3.Image;

            }
        }

        private void lbpreco8_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco2_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco3_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco4_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco5_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco6_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco7_Click(object sender, EventArgs e)
        {

        }

        private void lbpreco9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                total = total + Convert.ToDouble(textBox1.Text);
                lb_visor.Text = total.ToString("c2");
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(total>preco[0])
            {
                lb_troco.Text = (total - preco[0]).ToString("c2");
                imagem_troco.Image = pb1.Image;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (total > preco[1])
            {
                lb_troco.Text = (total - preco[1]).ToString("c2");
                imagem_troco.Image = pb2.Image;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (total > preco[3])
            {
                lb_troco.Text = (total - preco[3]).ToString("c2");
                imagem_troco.Image = pb4.Image;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (total > preco[4])
            {
                lb_troco.Text = (total - preco[4]).ToString("c2");
                imagem_troco.Image = pb5.Image;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (total > preco[5])
            {
                lb_troco.Text = (total - preco[5]).ToString("c2");
                imagem_troco.Image = pb6.Image;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (total > preco[6])
            {
                lb_troco.Text = (total - preco[6]).ToString("c2");
                imagem_troco.Image = pb7.Image;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (total > preco[7])
            {
                lb_troco.Text = (total - preco[7]).ToString("c2");
                imagem_troco.Image = pb8.Image;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (total > preco[8])
            {
                lb_troco.Text = (total - preco[8]).ToString("c2");
                imagem_troco.Image = pb9.Image;
            }
        }

        private void Btn_limpar(object sender, EventArgs e)
        {
            imagem_troco.Image = null;
            total = 0;
            lb_troco.Text = "";
            lb_visor.Text = "";

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void lb_visor_Click(object sender, EventArgs e)
        {

        }

        private void pb2_Click(object sender, EventArgs e)
        {

        }
    }
}
