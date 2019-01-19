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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.saha;
            tmrTop.Start();
        }

        private void tmrTop_Tick(object sender, EventArgs e)
        {
            
            pbBasketTopu.Left = rnd.Next(0, (this.Width - pbBasketTopu.Width ));
            pbBasketTopu.Top = rnd.Next(0, (this.Height - pbBasketTopu.Height ));
            if (pbBasketTopu.Bottom >=this.Height) //Width
            {
                pbBasketTopu.Left -= 30; //+
                pbBasketTopu.Top  -= 20;
            }
           else if (pbBasketTopu.Right >= this.Width) //Heighr
            {
                pbBasketTopu.Left += 30;
                pbBasketTopu.Top  += 20;
            }
           //else if(pbBasketTopu.Top >= this.Width) 
            //{
              //  pbBasketTopu.Left -= 30;
                //pbBasketTopu.Top += 20;
            //}
            //else if(pbBasketTopu.Left >= this.Height) 
            //{
              //  pbBasketTopu.Left -= 30;
               // pbBasketTopu.Top -= 20;
            //}
        }

        


    }

}
