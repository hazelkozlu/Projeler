using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OurLibrary
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }

        void Listele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var query = from item in de.KitapListesi()
                        select new
                        {
                            item.KITAPID,
                            item.KITAPAD,
                            item.YAZARADSOYAD,
                            item.TURAD,
                            item.BASIMYILI,
                            item.SAYFASAYISI,
                            item.OKUYAN

                        };
            gridControl1.DataSource = query.ToList();



        }
        void YazarListele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            CmbYazari.DataSource = de.TBL_YAZARLAR.ToList();
            CmbYazari.ValueMember = "YAZARID";
            CmbYazari.DisplayMember = "YAZARADSOYAD";
        }
        void YazarGetir(int Yazarid)
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            CmbYazari.DataSource = de.TBL_YAZARLAR.Where(a => a.YAZARID == Yazarid).ToList();
            CmbYazari.ValueMember = "YAZARID";
            CmbYazari.DisplayMember = "YAZARADSOYAD";
        }
        void TurListele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            CmbTuru.DataSource = de.TBL_TURLER.ToList();
            CmbTuru.ValueMember = "TURID";
            CmbTuru.DisplayMember = "TURAD";
        }
        void TurGetir(int Turid)
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            CmbTuru.DataSource = de.TBL_TURLER.Where(a => a.TURID == Turid).ToList();
            CmbTuru.ValueMember = "TURID";
            CmbTuru.DisplayMember = "TURAD";
        }
        void OkuyanListele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            CmbOkuyan.DataSource = de.Okuyucu().ToList();
            CmbOkuyan.ValueMember = "KULLANICIID";
            CmbOkuyan.DisplayMember = "OKUYAN";
        }
        void OkuyanGetir(int Kulid)
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            CmbOkuyan.DataSource = de.OkuyucuParm(Kulid).ToList();
            CmbOkuyan.ValueMember = "KULLANICIID";
            CmbOkuyan.DisplayMember = "OKUYAN";
        }

        void Temizle()
        {
            TxtKitapID.Text = "";
            TxtKitapAd.Text = "";
            TxtSayfaSayisi.Text = "";
            MskBasimYili.Text = "";
            CmbYazari.Text = "";
            CmbTuru.Text = "";
            CmbOkuyan.Text = "";

        }
        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            Listele();
            YazarListele();
            TurListele();
            OkuyanListele();


        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KITAPID"));
            TxtKitapID.Text = id.ToString();
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var t = de.TBL_KITAPLAR.Find(id);
            TxtKitapAd.Text = t.KITAPAD;
            int yazarid = Convert.ToInt32(t.KITAPYAZARID);
            YazarGetir(yazarid);
            int turid = Convert.ToInt32(t.KITAPTURID);
            TurGetir(turid);
            int okuyanid = Convert.ToInt32(t.OKUYANID);
            OkuyanGetir(okuyanid);
            TxtSayfaSayisi.Text = t.SAYFASAYISI.ToString();
            MskBasimYili.Text = t.BASIMYILI.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKitapAd.Text != "" && TxtSayfaSayisi.Text != "" &&
                CmbYazari.Text != "" && CmbTuru.Text != "" && CmbOkuyan.Text != "" && MskBasimYili.Text != "")
            {
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                TBL_KITAPLAR t = new TBL_KITAPLAR();
                t.KITAPAD = TxtKitapAd.Text.ToUpper();
                t.KITAPYAZARID = Convert.ToInt32(CmbYazari.SelectedValue);
                t.KITAPTURID = Convert.ToInt32(CmbTuru.SelectedValue);
                t.BASIMYILI = Convert.ToInt32(MskBasimYili.Text);
                t.OKUYANID = Convert.ToInt32(CmbOkuyan.SelectedValue);
                t.SAYFASAYISI = Convert.ToInt32(TxtSayfaSayisi.Text);
                de.TBL_KITAPLAR.Add(t);
                de.SaveChanges();
                MessageBox.Show("Kitap başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }


        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGuncellle_Click(object sender, EventArgs e)
        {

            if (TxtKitapAd.Text != "" && TxtSayfaSayisi.Text != "" &&
               CmbYazari.Text != "" && CmbTuru.Text != "" && CmbOkuyan.Text != "" && MskBasimYili.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KITAPID"));
                TxtKitapID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_KITAPLAR.Find(id);
                t.KITAPAD = TxtKitapAd.Text.ToUpper();
                t.KITAPYAZARID = Convert.ToInt32(CmbYazari.SelectedValue);
                t.KITAPTURID = Convert.ToInt32(CmbTuru.SelectedValue);
                t.BASIMYILI = Convert.ToInt32(MskBasimYili.Text);
                t.OKUYANID = Convert.ToInt32(CmbOkuyan.SelectedValue);
                t.SAYFASAYISI = Convert.ToInt32(TxtSayfaSayisi.Text);
                de.SaveChanges();
                MessageBox.Show("Kitap başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtKitapAd.Text != "" && TxtKitapID.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KITAPID"));
                TxtKitapID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_KITAPLAR.Find(id);
                de.TBL_KITAPLAR.Remove(t);
                de.SaveChanges();
                MessageBox.Show("Kitap başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydı seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            Listele();
            YazarListele();
            TurListele();
            OkuyanListele();
            Temizle();
        }
    }
}

