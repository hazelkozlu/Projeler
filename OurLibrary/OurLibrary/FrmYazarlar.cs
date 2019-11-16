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
    public partial class FrmYazarlar : Form
    {
        public FrmYazarlar()
        {
            InitializeComponent();
        }
        void Listele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var query = from item in de.TBL_YAZARLAR
                        select new
                        {
                            item.YAZARID,
                            item.YAZARADSOYAD
                        };
            gridControl1.DataSource = query.ToList();
        }
        void Temizle()
        {
            TxtYazarID.Text = "";
            TxtYazarAdSoyad.Text = "";


        }
        private void FrmYazarlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtYazarAdSoyad.Text != "")
            {
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                TBL_YAZARLAR t = new TBL_YAZARLAR();
                t.YAZARADSOYAD = TxtYazarAdSoyad.Text.ToUpper();
                de.TBL_YAZARLAR.Add(t);
                de.SaveChanges();
                MessageBox.Show("Yazar başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("YAZARID"));
            TxtYazarID.Text = id.ToString();
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var t = de.TBL_YAZARLAR.Find(id);
            TxtYazarAdSoyad.Text = t.YAZARADSOYAD;
        }

        private void BtnGuncellle_Click(object sender, EventArgs e)
        {
            if (TxtYazarAdSoyad.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("YAZARID"));
                TxtYazarID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_YAZARLAR.Find(id);
                t.YAZARADSOYAD = TxtYazarAdSoyad.Text.ToUpper();
                de.SaveChanges();
                MessageBox.Show("Yazar başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (TxtYazarAdSoyad.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("YAZARID"));
                TxtYazarID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_YAZARLAR.Find(id);
                de.TBL_YAZARLAR.Remove(t);
                de.SaveChanges();
                MessageBox.Show("Yazar başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
