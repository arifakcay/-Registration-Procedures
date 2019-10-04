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
    public partial class PageArac : Form
    {
        public PageArac()
        {
            InitializeComponent();
        }
        public PageMain pagemain;
      


        int ComboBoxItemNr = 0;

        enum araç   //girilecek araç sayisini enum ile belirledik, degistirilmek istenirse buradan degistirilmesi yeterli
        {
            sayisi = 20
        }


        enum araçMarka
        {
        Audi,
        Bmw,
        Fiat,
        Mercedes,
        Renault,
        }

        enum AudiModel
        {
            A1,
            A2,
            A3,
            A4,
            A5,
            A6,
            A7,
            A8,
            TT
        }

        enum BmwModel
        {
            M3,
            M4,
            M5
        }

        enum FiatModel
        {
            Linea,
            Egea,
            Punto,
            Bravo
        }

        enum MercedesModel
        {
            A180,
            CLA200,
            E350
        }

        enum RenaultModel
        {
            Megane,
            Clio,
            Symbol,
            Laguna,
            Fluence
        }

        enum kasaTip
        {
            HatchBack,
            Sedan,
            Station
        }

        String[] AraçMarka = new String[(int)araç.sayisi];
        String[] AraçModel = new String[(int)araç.sayisi];
        String[] AraçTip = new String[(int)araç.sayisi];
        String[] AraçYıl = new String[(int)araç.sayisi];

        private void PageArac_Load(object sender, EventArgs e)
        {
            //combobox'a enum'daki verileri ekleme.
            comboBoxMarkaEkle.Items.AddRange(Enum.GetNames(typeof(araçMarka)));
            comboBoxTipEkle.Items.AddRange(Enum.GetNames(typeof(kasaTip)));
        }

        private void ComboBoxAraçSeç_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMarka.Text = AraçMarka[comboBoxAraçSeç.SelectedIndex + 1];
            lblModel.Text = AraçModel[comboBoxAraçSeç.SelectedIndex + 1];
            lblTip.Text = AraçTip[comboBoxAraçSeç.SelectedIndex + 1];
            lblYıl.Text = AraçYıl[comboBoxAraçSeç.SelectedIndex + 1];
        }



 
        private void ComboBoxMarkaEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarkaEkle.Text == "Audi")
            {
                comboBoxModelEkle.Items.Clear();
                comboBoxModelEkle.Items.AddRange(Enum.GetNames(typeof(AudiModel)));
            }
            else if (comboBoxMarkaEkle.Text == "Bmw")
            {
                comboBoxModelEkle.Items.Clear();
                comboBoxModelEkle.Items.AddRange(Enum.GetNames(typeof(BmwModel)));
            }
            else if (comboBoxMarkaEkle.Text == "Fiat")
            {
                comboBoxModelEkle.Items.Clear();
                comboBoxModelEkle.Items.AddRange(Enum.GetNames(typeof(FiatModel)));
            }
            else if (comboBoxMarkaEkle.Text == "Mercedes")
            {
                comboBoxModelEkle.Items.Clear();
                comboBoxModelEkle.Items.AddRange(Enum.GetNames(typeof(MercedesModel)));
            }
            else if (comboBoxMarkaEkle.Text == "Renault")
            {
                comboBoxModelEkle.Items.Clear();
                comboBoxModelEkle.Items.AddRange(Enum.GetNames(typeof(RenaultModel)));
            }

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

        private void ButtonMainPage_Click(object sender, EventArgs e)
        {
            //PageMain pagemain = new PageMain();
            pagemain.Show();
            this.Hide();
        }

        private void ButtonAracccEkle_Click(object sender, EventArgs e)
        {
            //araç bilgilerinin tamamı dolu değilse kayıt yapmasın.
                if (comboBoxMarkaEkle.Text != "" && comboBoxModelEkle.Text != "" && comboBoxTipEkle.Text != "" && textBoxYılEkle.Text != "")
            {
                ComboBoxItemNr = ComboBoxItemNr + 1;     // index numaralarını belirtmek için tanımladık.
                comboBoxAraçSeç.Items.Add(Convert.ToString(ComboBoxItemNr));   // combobox'a numaraları eklemeye yarıyor.
                comboBoxAraçSeç.Text = Convert.ToString(ComboBoxItemNr);     // combobox'a eklenen numarayı seçiyor.

                // araç bilgilerini girmiş olduğumuz textbox'taki bilgileri araç bilgileri
                //dizilerini atıyor. yani her girilen bilgide numara bir arttığı için labellarda
                //gösterilen değerler kullanıcının seçimine bırakılıyor.
                AraçMarka[ComboBoxItemNr] = comboBoxMarkaEkle.Text;
                AraçModel[ComboBoxItemNr] = comboBoxModelEkle.Text;
                AraçTip[ComboBoxItemNr] = comboBoxTipEkle.Text;
                AraçYıl[ComboBoxItemNr] = textBoxYılEkle.Text;

                // Dizilerde tutulan bilgileri index numaralarına göre labellar aracılığı ile kullanıcıya sunuyor.
                lblMarka.Text = AraçMarka[comboBoxAraçSeç.SelectedIndex + 1];
                lblModel.Text = AraçModel[comboBoxAraçSeç.SelectedIndex + 1];
                lblTip.Text = AraçTip[comboBoxAraçSeç.SelectedIndex + 1];
                lblYıl.Text = AraçYıl[comboBoxAraçSeç.SelectedIndex + 1];


                comboBoxMarkaEkle.Text = "";
                comboBoxModelEkle.Text = "";
                comboBoxTipEkle.Text = "";
                textBoxYılEkle.Clear();
            }
        }
    }
    }

