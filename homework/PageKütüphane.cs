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
    public partial class PageKütüphane : Form
    {
        public PageKütüphane()
        {
            InitializeComponent();
        }
        public PageMain pagemain;
       
        int ComboBoxItemNr = 0;

        enum kitap   //girilecek kitap sayisini enum ile belirledik, degistirilmek istenirse buradan degistirilmesi yeterli
        {
            sayisi = 20
        }
       

        enum kitapTür
        {
            roman,
            hikaye,
            tarih,
            felsefe,
            din,
            psikoloji,
            dram
        }


        String[] KitapAd = new String[(int)kitap.sayisi];
        String[] KitapYazar = new String[(int)kitap.sayisi];
        String[] KitapTür = new String[(int)kitap.sayisi];
        String[] KitapYıl = new String[(int)kitap.sayisi];



        private void ButtonKediEkle_Click(object sender, EventArgs e)
        {
            //Kitap bilgilerinin tamamı dolu değilse kayıt yapmasın.
            if (textBoxAdEkle.Text != "" && textBoxYazarEkle.Text != "" && comboBoxTürEkle.Text != "" && textBoxYılEkle.Text != "")
            {
                ComboBoxItemNr = ComboBoxItemNr + 1;     // index numaralarını belirtmek için tanımladık.
                comboBoxKitapSec.Items.Add(Convert.ToString(ComboBoxItemNr));   // combobox'a numaraları eklemeye yarıyor.
                comboBoxKitapSec.Text = Convert.ToString(ComboBoxItemNr);     // combobox'a eklenen numarayı seçiyor.

                // Kitap bilgilerini girmiş olduğumuz textbox'taki bilgileri kitap bilgileri
                //dizilerini atıyor. yani her girilen bilgide numara bir arttığı için labellarda
                //gösterilen değerler kullanıcının seçimine bırakılıyor.
                KitapAd[ComboBoxItemNr] = textBoxAdEkle.Text;
                KitapYazar[ComboBoxItemNr] = textBoxYazarEkle.Text;
                KitapTür[ComboBoxItemNr] = comboBoxTürEkle.Text;
                KitapYıl[ComboBoxItemNr] = textBoxYılEkle.Text;

                // Dizilerde tutulan bilgileri index numaralarına göre labellar aracılığı ile kullanıcıya sunuyor.
                lblAd.Text = KitapAd[comboBoxKitapSec.SelectedIndex + 1];
                lblYazar.Text = KitapYazar[comboBoxKitapSec.SelectedIndex + 1];
                lblTür.Text = KitapTür[comboBoxKitapSec.SelectedIndex + 1];
                lblYıl.Text = KitapYıl[comboBoxKitapSec.SelectedIndex + 1];


                textBoxAdEkle.Clear();
                textBoxYazarEkle.Clear();
                comboBoxTürEkle.Text = "";
                textBoxYılEkle.Clear();
            }


        }

        private void ComboBoxKitapSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAd.Text = KitapAd[comboBoxKitapSec.SelectedIndex + 1];
            lblYazar.Text = KitapYazar[comboBoxKitapSec.SelectedIndex + 1];
            lblTür.Text = KitapTür[comboBoxKitapSec.SelectedIndex + 1];
            lblYıl.Text = KitapYıl[comboBoxKitapSec.SelectedIndex + 1];
        }

        private void PageKütüphane_Load(object sender, EventArgs e)
        {


            //combobox'a enum'daki verileri ekleme.
            comboBoxTürEkle.Items.AddRange(Enum.GetNames(typeof(kitapTür)));
        }

        private void TextBoxYılEkle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ButtonMainPageLibrary_Click(object sender, EventArgs e)
        {
            pagemain.Show();
            this.Hide();
        }
    }
}

