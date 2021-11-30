using System;
using System.Windows.Forms;

namespace JogoDaVelhaWF
{
    public partial class Form1 : Form
    {
        public int Partida { get; set; } = 1;
        public int X { get; set; } = 0;
        public int O { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AlterarPartida()
        {
            Partida++;
            if (Partida % 2 != 0)
                LInicia.Text = $"O inicia";
            else
                LInicia.Text = $"X inicia";

            LPartida.Text = $"{Partida}ª PARTIDA";
        }

        private void RealizarJogada(object sender)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (Partida % 2 == 0)
                {
                    if (NumJogadas() % 2 == 0)
                        button.Text = "X";

                    else
                        button.Text = "O";
                }
                else
                {
                    if (NumJogadas() % 2 == 0)
                        button.Text = "O";

                    else
                        button.Text = "X";
                }

                if (VerificarVencedor())
                {
                    LimparJogo();
                    AlterarPartida();
                    AtualizarPlacar();
                }
            }
            else
                MessageBox.Show("Já existe um valor aqui!");
        }

        private int NumJogadas()
        {
            int numJogadas = 0;

            if (button1.Text != "")
                numJogadas++;
            if (button2.Text != "")
                numJogadas++;
            if (button3.Text != "")
                numJogadas++;
            if (button4.Text != "")
                numJogadas++;
            if (button5.Text != "")
                numJogadas++;
            if (button6.Text != "")
                numJogadas++;
            if (button7.Text != "")
                numJogadas++;
            if (button8.Text != "")
                numJogadas++;
            if (button9.Text != "")
                numJogadas++;

            return numJogadas;
        }

        private void button_Click(object sender, EventArgs e)
        {
            RealizarJogada(sender);
        }

        private bool VerificarVencedor()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button1.Text} venceu!");
                AtribuirPonto(button1.Text);
                return true;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button1.Text} venceu!");
                AtribuirPonto(button1.Text);
                return true;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button1.Text} venceu!");
                AtribuirPonto(button1.Text);
                return true;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button2.Text} venceu!");
                AtribuirPonto(button2.Text);
                return true;
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button3.Text} venceu!");
                AtribuirPonto(button3.Text);
                return true;
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text && button9.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button3.Text} venceu!");
                AtribuirPonto(button3.Text);
                return true;
            }
            else if (button5.Text == button6.Text && button4.Text == button5.Text && button5.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button4.Text} venceu!");
                AtribuirPonto(button4.Text);
                return true;
            }
            else if (button7.Text == button8.Text && button9.Text == button7.Text && button7.Text != "")
            {
                MessageBox.Show($"Parabens, jogador {button7.Text} venceu!");
                AtribuirPonto(button7.Text);
                return true;
            }
            else if (NumJogadas() > 8)
            {
                MessageBox.Show($"Empate!");
                return true;
            }
            else
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

        private void AtribuirPonto(string vencedor)
        {
            if (vencedor == "X")
                X++;

            else
                O++;
        }

        private void AtualizarPlacar()
        {
            LPlacar.Text = $"X = {X} vs. {O} = O";
        }
    }
}
