using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int a = 0;
            int x = 20,y=20;  //dama pozisyon başlangıç noktası

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button();
                    btn.Text = "";
                    btn.Width = 80;
                    btn.Height = 80;
                    btn.Location = new Point(x, y);
                    btn.FlatStyle = FlatStyle.Flat;

                    btn.BackColor = a % 2 == 0 ? Color.Black : Color.White; //farklı renkler için

                    //if (a % 2 == 0)
                    //{
                    //    btn.BackColor = Color.Black;
                    //}
                    //else
                    //{
                    //    btn.BackColor = Color.White;
                    //}

                    this.Controls.Add(btn); //controle butonu ekle

                    x += 80; //sağa atlat
                    a++;

                }

                a++;
                x = 20; //satır başı
                y += 80; //alta atlat
            }

        }
    }
}
