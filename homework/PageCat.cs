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
    public partial class PageCat : Form
    {
        public PageCat()
        {
            InitializeComponent();
        }
        public PageMain pagemain;
        private void Button1_Click(object sender, EventArgs e)
        {
            //PageMain pagemain = new PageMain();
            pagemain.Show();
            this.Hide();
        }
        ///////////////////////////////////////////////////////////////
        int ComboBoxItemNr = 0;       

        public enum kedi   //girilecek kedi sayisini enum ile belirledik, degistirilmek istenirse buradan degistirilmesi yeterli
        {
            sayisi= 20, 
        }



        String[] KediAd = new String[(int)kedi.sayisi];
        String[] KediRenk = new String[(int)kedi.sayisi];
        String[] KediCins = new String[(int)kedi.sayisi];
        String[] KediYas = new String[(int)kedi.sayisi];




        private void ButtonKediEkle_Click(object sender, EventArgs e)
        {


            //Kedi bilgilerinin tamamı dolu değilse kayıt yapmasın.
            if (textBoxAdEkle.Text != "" && textBoxRenkEkle.Text != "" && comboBoxCinsEkle.Text != "" && textBoxYasEkle.Text != "")
            {
                ComboBoxItemNr = ComboBoxItemNr + 1;     // index numaralarını belirtmek için tanımladık.
                comboBoxKediSec.Items.Add(Convert.ToString(ComboBoxItemNr));   // combobox'a numaraları eklemeye yarıyor.
                comboBoxKediSec.Text = Convert.ToString(ComboBoxItemNr);     // combobox'a eklenen numarayı seçiyor.

                // Kedi bilgilerini girmiş olduğumuz textbox'taki bilgileri kedi bilgileri
                //dizilerini atıyor. yani her girilen bilgide numara bir arttığı için labellarda
                //gösterilen değerler kullanıcının seçimine bırakılıyor.
                KediAd[ComboBoxItemNr] = textBoxAdEkle.Text;
                KediRenk[ComboBoxItemNr] = textBoxRenkEkle.Text;
                KediCins[ComboBoxItemNr] = comboBoxCinsEkle.Text;
                KediYas[ComboBoxItemNr] = textBoxYasEkle.Text;

                // Dizilerde tutulan bilgileri index numaralarına göre labellar aracılığı ile kullanıcıya sunuyor.
                lblAd.Text = KediAd[comboBoxKediSec.SelectedIndex + 1];
                lblRenk.Text = KediRenk[comboBoxKediSec.SelectedIndex + 1];
                lblCins.Text = KediCins[comboBoxKediSec.SelectedIndex + 1];
                lblYas.Text = KediYas[comboBoxKediSec.SelectedIndex + 1];


                textBoxAdEkle.Clear();
                textBoxRenkEkle.Clear();
                comboBoxCinsEkle.Text = "";
                textBoxYasEkle.Clear();
            }
        }


        private void ComboBoxKediSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAd.Text = KediAd[comboBoxKediSec.SelectedIndex + 1];
            lblRenk.Text = KediRenk[comboBoxKediSec.SelectedIndex + 1];
            lblCins.Text = KediCins[comboBoxKediSec.SelectedIndex + 1];
            lblYas.Text = KediYas[comboBoxKediSec.SelectedIndex + 1];
        }

        private void TextBoxYasEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

 
    }
}
