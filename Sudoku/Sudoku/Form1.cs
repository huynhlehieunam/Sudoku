using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        Sudoku s;
        int lv;
        public Form1()
        {
            InitializeComponent();
 
            
        }
        int time = 900;
        private void button1_Click(object sender, EventArgs e)
        {
            time = 900;
            if (cbLevel.SelectedIndex == -1) { txtKQ.Text = "Loi chua nhap do kho"; return; }
            else{
                lv = (cbLevel.SelectedIndex + 3) * 9;
            };
            s = null;
            s = new Sudoku(9, lv);
            makeBoard();
            timer1.Enabled = true;
        }
        void makeBoard()
        {
            pBoard.Controls.Clear();
            int posX=0, posY=0;
            s.fillValues();
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    TextBox t = new TextBox();
                    t.Name = "a[" + i + "," + j + "]";
                    t.Location = new Point(posX, posY);
                    t.Width = 28;
                    t.Height = 28;
                    t.Text = s.covered[i, j].ToString() ;
                    t.Leave += T_Leave;


                    if (t.Text == "0") t.BackColor = Color.Red;
                    else
                    {
                        t.ReadOnly = true;
                    }
                    t.Multiline = true;
                    posX += 32;
                    pBoard.Controls.Add(t);
                };
                posX = 0;
                posY += 32;
            }
        }
        private void T_Leave(object sender, EventArgs e)
        {
            string t = (sender as TextBox).Text;
            (sender as TextBox).Text = t[0].ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            int i = 0, j = 0;
            foreach(TextBox t in pBoard.Controls)
            {
                s.player[i, j] = Int16.Parse(t.Text);
                if (i == 8) { i = 0;j++; }
                else i++;
            }
            if (s.checkWin() == true) txtKQ.Text = "Thanh cong";
            else txtKQ.Text = "That bai";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lbTime.Text = "00:" + time / 60 + ":" + time % 60;
            if(time==0)
            {
                if (s.checkWin() == true) txtKQ.Text = "Thanh cong";
                else txtKQ.Text = "That bai";
                timer1.Enabled = false;

            }
        }
        
    }
}
