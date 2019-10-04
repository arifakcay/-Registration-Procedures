using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class PageMain : Form
    {
        public PageMain()
        {
            InitializeComponent();
        }

        PageCat cat = new PageCat();
        PageKütüphane kütüphane = new PageKütüphane();
        PageArac arac = new PageArac();
       

       

       

        private void ButtonCat_Click(object sender, EventArgs e)
        {
            //PageCat cat = new PageCat();
            cat.pagemain = this;
            cat.Show();
            this.Hide();
        }

        private void ButtonLibrary_Click(object sender, EventArgs e)
        {
            //PageKütüphane kütüphane = new PageKütüphane();
            kütüphane.pagemain = this;
            kütüphane.Show();
            this.Hide();
        }

        private void ButtonVehicle_Click(object sender, EventArgs e)
        {
            //PageArac arac = new PageArac();
            arac.pagemain = this;
            arac.Show();
            this.Hide();

        }
    }
}
