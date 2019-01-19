using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABasket_Topu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private int sagsol;
        private int altust;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.saha;
            pbBasketTopu.Left = rnd.Next(0, (this.Width - pbBasketTopu.Width ));
            pbBasketTopu.Top = rnd.Next(0, (this.Height - pbBasketTopu.Height ));
            this.sagsol = 5;  // mesela
            this.altust = 10; // mesela
            tmrTop.Start();
        }

        private void tmrTop_Tick(object sender, EventArgs e)
        {
            
            pbBasketTopu.Left += this.sagsol;
            pbBasketTopu.Top += this.altust;
            if (pbBasketTopu.Bottom >=this.Height) //Width
            {
                this.altust *= -1;
            }
            else if (pbBasketTopu.Right >= this.Width) //Heighr
            {
                this.sagsol *= -1;
            }
            else if(pbBasketTopu.Top < 0) 
            {
                this.altust *= -1;
            }
            else if(pbBasketTopu.Left < 0) 
            {
                this.sagsol *= -1;
            }
        }

        


    }

}
