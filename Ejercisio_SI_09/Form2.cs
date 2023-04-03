using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercisio_SI_09
{
    public partial class Form2 : Form
    {

        public static string play;
        public static string[,] matriz = new string[3, 3] { { "", "", "" }, { "",  "", "" }, {"","","" } };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            play = "O";
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play = "X";
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            play = "O";
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            button12.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox1.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox1.Enabled = false;
                    matriz[0, 0] = play;
                    if (play == matriz[0, 1] && play == matriz[0, 2])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if(play == matriz[1, 1] && play == matriz[2, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[1, 0] && play == matriz[2, 0])
                            {
                                MessageBox.Show("El jugador 1 Gana !!");
                            }
                        }
                    }
                    break;
                case "X":
                    pictureBox1.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox1.Enabled = false;
                    matriz[0, 0] = play;
                    if (play == matriz[0, 1] && play == matriz[0, 2])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[2, 2])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[1, 0] && play == matriz[2, 0])
                            {
                                MessageBox.Show("El jugador 2 Gana !!");
                            }
                        }
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox2.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox2.Enabled = false;
                    matriz[0, 1] = play;
                    if (play == matriz[1, 1] && play == matriz[2, 1])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[0, 0] && play == matriz[0, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                    }                    
                    break;
                case "X":
                    pictureBox2.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox2.Enabled = false;
                    matriz[0, 1] = play;
                    if (play == matriz[1, 1] && play == matriz[2, 1])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    if (play == matriz[0, 0] && play == matriz[0, 2])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                        
                    }
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox3.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox3.Enabled = false;
                    matriz[0, 2] = play;
                    if (play == matriz[0, 0] && play == matriz[0, 1])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[2, 0])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[1, 2] && play == matriz[2, 2])
                            {
                                MessageBox.Show("El jugador 1 Gana !!");
                            }
                        }
                    }
                    break;
                case "X":
                    pictureBox3.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox3.Enabled = false;
                    matriz[0, 2] = play;
                    if (play == matriz[0, 0] && play == matriz[0, 1])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[2, 0])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[1, 2] && play == matriz[2, 2])
                            {
                                MessageBox.Show("El jugador 2 Gana !!");
                            }
                        }
                    }
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox4.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox4.Enabled = false;
                    matriz[1, 0] = play;
                    if (play == matriz[0, 0] && play == matriz[2, 0])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[1, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                    }
                    break;
                case "X":
                    pictureBox4.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox4.Enabled = false;
                    matriz[1, 0] = play;
                    if (play == matriz[0, 0] && play == matriz[2, 0])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[1, 2])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                    }
                    break;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox5.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox5.Enabled = false;
                    matriz[1, 1] = play;
                    if (play == matriz[0, 1] && play == matriz[2, 1])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 0] && play == matriz[1, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                    }
                    break;
                case "X":
                    pictureBox5.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox5.Enabled = false;
                    matriz[1, 1] = play;
                    if (play == matriz[0, 1] && play == matriz[2, 1])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 0] && play == matriz[1, 2])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                    }
                    break;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox6.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox6.Enabled = false;
                    matriz[1, 2] = play;
                    if (play == matriz[1, 0] && play == matriz[1, 1])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[0, 2] && play == matriz[2, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                    }
                    break;
                case "X":
                    pictureBox6.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox6.Enabled = false;
                    matriz[1, 2] = play;
                    if (play == matriz[1, 0] && play == matriz[1, 1])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[0, 2] && play == matriz[2, 2])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                    }
                    break;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox7.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox7.Enabled = false;
                    matriz[2, 0] = play;
                    if (play == matriz[0, 0] && play == matriz[1, 0])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[0, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[2, 1] && play == matriz[2, 2])
                            {
                                MessageBox.Show("El jugador 1 Gana !!");
                            }
                        }
                    }
                    break;
                case "X":
                    pictureBox7.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox7.Enabled = false;
                    matriz[2, 0] = play;
                    if (play == matriz[0, 0] && play == matriz[1, 0])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[1, 1] && play == matriz[0, 2])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[2, 1] && play == matriz[2, 2])
                            {
                                MessageBox.Show("El jugador 2 Gana !!");
                            }
                        }
                    }
                    break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox8.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox8.Enabled = false;
                    matriz[2, 1] = play;
                    if (play == matriz[1, 1] && play == matriz[0, 1])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[2, 0] && play == matriz[2, 2])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                    }
                    break;
                case "X":
                    pictureBox8.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox8.Enabled = false;
                    matriz[2, 1] = play;
                    if (play == matriz[1, 1] && play == matriz[0, 1])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[2, 0] && play == matriz[2, 2])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                    }
                    break;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case "O":
                    pictureBox9.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY1.png");
                    pictureBox9.Enabled = false;
                    matriz[2, 2] = play;
                    if (play == matriz[2, 0] && play == matriz[2, 1])
                    {
                        MessageBox.Show("El jugador 1 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[0, 0] && play == matriz[1, 1])
                        {
                            MessageBox.Show("El jugador 1 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[0, 2] && play == matriz[1, 2])
                            {
                                MessageBox.Show("El jugador 1 Gana !!");
                            }
                        }
                    }
                    break;
                case "X":
                    pictureBox9.Image = Image.FromFile(@"E:\Proyectos\Ejercisio_SI_09\Ejercisio_SI_09\Resources\PLAY2.jpg");
                    pictureBox9.Enabled = false;
                    matriz[2, 2] = play;
                    if (play == matriz[2, 0] && play == matriz[2, 1])
                    {
                        MessageBox.Show("El jugador 2 Gana !!");
                    }
                    else
                    {
                        if (play == matriz[0, 0] && play == matriz[1, 1])
                        {
                            MessageBox.Show("El jugador 2 Gana !!");
                        }
                        else
                        {
                            if (play == matriz[0, 2] && play == matriz[1, 2])
                            {
                                MessageBox.Show("El jugador 2 Gana !!");
                            }
                        }
                    }
                    break;
            }
        }
    }
}
