using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelhaWF
{
    public partial class Form1 : Form
    {
        public int Count { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void RealizarJogada(object sender)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (NumJogadas() % 2 == 0)
                    button.Text = "O";

                else
                    button.Text = "X";

                if (VerificarVencedor())
                    LimparJogo();
            }
            else
                MessageBox.Show("Já existe um valor aqui!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private int NumJogadas()
        {
            int numJogadas = 0;

            if (button1.Text == "")
                numJogadas++;
            if (button2.Text == "")
                numJogadas++;
            if (button3.Text == "")
                numJogadas++;
            if (button4.Text == "")
                numJogadas++;
            if (button5.Text == "")
                numJogadas++;
            if (button6.Text == "")
                numJogadas++;
            if (button7.Text == "")
                numJogadas++;
            if (button8.Text == "")
                numJogadas++;
            if (button9.Text == "")
                numJogadas++;

            return numJogadas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private bool VerificarVencedor()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button1.Text} venceu!");
                return true;
            }
            if(button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button1.Text} venceu!");
                return true;
            }
            if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button1.Text} venceu!");
                return true;
            }
            if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button2.Text} venceu!");
                return true;
            }
            if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button3.Text} venceu!");
                return true;
            }
            if (button3.Text == button6.Text && button3.Text == button9.Text && button9.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button3.Text} venceu!");
                return true;
            }
            if (button5.Text == button6.Text && button4.Text == button5.Text && button5.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button4.Text} venceu!");
                return true;
            }
            if (button7.Text == button8.Text && button9.Text == button7.Text && button7.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button7.Text} venceu!");
                return true;
            }
            if(NumJogadas() > 8)
            {
                MessageBox.Show($"Empate!");
                return true;
            }
            return false;
        }

        private void LimparJogo()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}
