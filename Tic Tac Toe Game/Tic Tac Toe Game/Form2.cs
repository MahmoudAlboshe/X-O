﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form2 : Form
    {
        Boolean Player, Win;
        int[,] PlayerX = new int[3, 4];
        int[,] PlayerO = new int[3, 4];
        int Full = 0;
        void Clear_Box()
        {
            btn_1.Text = "";
            btn_2.Text = "";
            btn_3.Text = "";
            btn_4.Text = "";
            btn_5.Text = "";
            btn_6.Text = "";
            btn_7.Text = "";
            btn_8.Text = "";
            btn_9.Text = "";
        }
        void Active_Box()
        {
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_1.BackColor = Color.WhiteSmoke;
            btn_2.BackColor = Color.WhiteSmoke;
            btn_3.BackColor = Color.WhiteSmoke;
            btn_4.BackColor = Color.WhiteSmoke;
            btn_5.BackColor = Color.WhiteSmoke;
            btn_6.BackColor = Color.WhiteSmoke;
            btn_7.BackColor = Color.WhiteSmoke;
            btn_8.BackColor = Color.WhiteSmoke;
            btn_9.BackColor = Color.WhiteSmoke;
        }
        Boolean CheckX(ref int k)
        {
            int i;
            k = 1;
            for (i = 0; i < 3; i++)
            {
                if (PlayerX[i, 0] == 3)
                    return true;
                k++;
            }
            for (i = 0; i < 3; i++)
            {
                if (PlayerX[i, 1] == 3)
                    return true;
                k++;
            }
            if (PlayerX[0, 2] == 1 && PlayerX[1, 2] == 1 && PlayerX[2, 2] == 1)
                return true;
            k++;
            if (PlayerX[0, 3] == 1 && PlayerX[1, 3] == 1 && PlayerX[2, 3] == 1)
                return true;
            return false;
        }
        Boolean CheckO(ref int k)
        {
            int i;
            k = 1;
            for (i = 0; i < 3; i++)
            {
                if (PlayerO[i, 0] == 3)
                    return true;
                k++;
            }
            for (i = 0; i < 3; i++)
            {
                if (PlayerO[i, 1] == 3)
                    return true;
                k++;
            }
            if (PlayerO[0, 2] == 1 && PlayerO[1, 2] == 1 && PlayerO[2, 2] == 1)
                return true;
            k++;
            if (PlayerO[0, 3] == 1 && PlayerO[1, 3] == 1 && PlayerO[2, 3] == 1)
                return true;
            return false;
        }
        void EndGame(int k, char p)
        {
            switch (k)
            {
                case 1:
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_1.BackColor = Color.Red;
                        btn_2.BackColor = Color.Red;
                        btn_3.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_1.BackColor = Color.Lime;
                        btn_2.BackColor = Color.Lime;
                        btn_3.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 2:
                    btn_4.BackColor = Color.Red;
                    btn_5.BackColor = Color.Red;
                    btn_6.BackColor = Color.Red;
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_4.BackColor = Color.Red;
                        btn_5.BackColor = Color.Red;
                        btn_6.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_4.BackColor = Color.Lime;
                        btn_5.BackColor = Color.Lime;
                        btn_6.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 3:
                    
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_7.BackColor = Color.Red;
                        btn_8.BackColor = Color.Red;
                        btn_9.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_7.BackColor = Color.Lime;
                        btn_8.BackColor = Color.Lime;
                        btn_9.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 4:
                    
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_1.BackColor = Color.Red;
                        btn_4.BackColor = Color.Red;
                        btn_7.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_1.BackColor = Color.Lime;
                        btn_4.BackColor = Color.Lime;
                        btn_7.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 5:
                    
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_2.BackColor = Color.Red;
                        btn_5.BackColor = Color.Red;
                        btn_8.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_2.BackColor = Color.Lime;
                        btn_5.BackColor = Color.Lime;
                        btn_8.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 6:
                    
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_3.BackColor = Color.Red;
                        btn_6.BackColor = Color.Red;
                        btn_9.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_3.BackColor = Color.Lime;
                        btn_6.BackColor = Color.Lime;
                        btn_9.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 7:
                    
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_1.BackColor = Color.Red;
                        btn_5.BackColor = Color.Red;
                        btn_9.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_1.BackColor = Color.Lime;
                        btn_5.BackColor = Color.Lime;
                        btn_9.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
                case 8:
                    
                    if (p == 'X')
                    {
                        lbl_X.Text = Convert.ToString(int.Parse(lbl_X.Text) + 1);
                        btn_3.BackColor = Color.Red;
                        btn_5.BackColor = Color.Red;
                        btn_7.BackColor = Color.Red;
                        MessageBox.Show("Player (X) Is Winner", "Viwe Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lbl_O.Text = Convert.ToString(int.Parse(lbl_O.Text) + 1);
                        btn_3.BackColor = Color.Lime;
                        btn_5.BackColor = Color.Lime;
                        btn_7.BackColor = Color.Lime;
                        MessageBox.Show("Player (O) Is Winner", "Viwe Winner", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    pnl_Game.Enabled = false;
                    break;
            }
        }

        void CheckResult()
        {
            int k = 0;
            Full++;
            if (CheckX(ref k))
            {
                EndGame(k, 'X');
                Win = true;
            }
            else
                if (CheckO(ref k))
                {
                    EndGame(k, 'O');
                    Win = true;
                }
            if (Full == 9 && !Win)
            {
                MessageBox.Show("End Game No Winner... Ckick New Game", "View Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnl_Game.Enabled = false;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Ex_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            Clear_Box();
            Active_Box();
            lbl_X.Text = "0";
            lbl_O.Text = "0";
            Full = 0;
            pnl_Game.Enabled = true;
            Player = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    PlayerX[i, j] = 0;
                    PlayerO[i, j] = 0;
                }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Full = 0;
            pnl_Game.Enabled = true;
            Win = false;
            Clear_Box();
            Active_Box();
            Player = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    PlayerX[i, j] = 0;
                    PlayerO[i, j] = 0;
                }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Player = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    PlayerX[i, j] = 0;
                    PlayerO[i, j] = 0;
                }
            btn_1.BackColor = Color.WhiteSmoke;
            btn_2.BackColor = Color.WhiteSmoke;
            btn_3.BackColor = Color.WhiteSmoke;
            btn_4.BackColor = Color.WhiteSmoke;
            btn_5.BackColor = Color.WhiteSmoke;
            btn_6.BackColor = Color.WhiteSmoke;
            btn_7.BackColor = Color.WhiteSmoke;
            btn_8.BackColor = Color.WhiteSmoke;
            btn_9.BackColor = Color.WhiteSmoke;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_1.Text = "X";
                Player = true;
                PlayerX[0, 0]++;
                PlayerX[0, 1]++;
                PlayerX[0, 2]++;

            }
            else
            {
                btn_1.Text = "O";
                Player = false;
                PlayerO[0, 0]++;
                PlayerO[0, 1]++;
                PlayerO[0, 2]++;


            }
            btn_1.Enabled = false;
            CheckResult();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_2.Text = "X";
                Player = true;
                PlayerX[0, 0]++;
                PlayerX[1, 1]++;

            }
            else
            {
                btn_2.Text = "O";
                Player = false;
                PlayerO[0, 0]++;
                PlayerO[1, 1]++;
            }
            btn_2.Enabled = false;
            CheckResult();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_3.Text = "X";
                Player = true;
                PlayerX[0, 0]++;
                PlayerX[2, 1]++;
                PlayerX[0, 3]++;
            }
            else
            {
                btn_3.Text = "O";
                Player = false;
                PlayerO[0, 0]++;
                PlayerO[2, 1]++;
                PlayerO[0, 3]++;
            }
            btn_3.Enabled = false;
            CheckResult();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_4.Text = "X";
                Player = true;
                PlayerX[1, 0]++;
                PlayerX[0, 1]++;
            }
            else
            {
                btn_4.Text = "O";
                Player = false;
                PlayerO[1, 0]++;
                PlayerO[0, 1]++;
            }
            btn_4.Enabled = false;
            CheckResult();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_5.Text = "X";
                Player = true;
                PlayerX[1, 0]++;
                PlayerX[1, 1]++;
                PlayerX[1, 2]++;
                PlayerX[1, 3]++;
            }
            else
            {
                btn_5.Text = "O";
                Player = false;
                PlayerO[1, 0]++;
                PlayerO[1, 1]++;
                PlayerO[1, 2]++;
                PlayerO[1, 3]++;
            }
            btn_5.Enabled = false;
            CheckResult();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_6.Text = "X";
                Player = true;
                PlayerX[1, 0]++;
                PlayerX[2, 1]++;
            }
            else
            {
                btn_6.Text = "O";
                Player = false;
                PlayerO[1, 0]++;
                PlayerO[2, 1]++;
            }
            btn_6.Enabled = false;
            CheckResult();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_7.Text = "X";
                Player = true;
                PlayerX[2, 0]++;
                PlayerX[0, 1]++;
                PlayerX[2, 3]++;

            }
            else
            {
                btn_7.Text = "O";
                Player = false;
                PlayerO[2, 0]++;
                PlayerO[0, 1]++;
                PlayerO[2, 3]++;
            }
            btn_7.Enabled = false;
            CheckResult();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_8.Text = "X";
                Player = true;
                PlayerX[2, 0]++;
                PlayerX[1, 1]++;
            }
            else
            {
                btn_8.Text = "O";
                Player = false;
                PlayerO[2, 0]++;
                PlayerO[1, 1]++;
            }
            btn_8.Enabled = false;
            CheckResult();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (!Player)
            {
                btn_9.Text = "X";
                Player = true;
                PlayerX[2, 0]++;
                PlayerX[2, 1]++;
                PlayerX[2, 2]++;
            }
            else
            {
                btn_9.Text = "O";
                Player = false;
                PlayerO[2, 0]++;
                PlayerO[2, 1]++;
                PlayerO[2, 2]++;
            }
            btn_9.Enabled = false;
            CheckResult();
        }
    }
}
