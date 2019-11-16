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
    public partial class FrmAlinacak : Form
    {
        public FrmAlinacak()
        {
            InitializeComponent();
        }
        void Listele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var query = from item in de.TBL_ALINACAK
                        select new
                        {
                            item.ALKITAPID,
                            item.ALKITAPAD
                        };
            gridControl1.DataSource = query.ToList();
        }
        void Temizle()
        {
            TxtAlKitapID.Text = "";
            TxtAlKitapAd.Text = "";


        }
        private void FrmAlinacak_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAlKitapAd.Text != "")
            {
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                TBL_ALINACAK t = new TBL_ALINACAK();
                t.ALKITAPAD = TxtAlKitapAd.Text.ToUpper();
                de.TBL_ALINACAK.Add(t);
                de.SaveChanges();
                MessageBox.Show("Alınacak Kitap başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ALKITAPID"));
            TxtAlKitapID.Text = id.ToString();
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var t = de.TBL_ALINACAK.Find(id);
            TxtAlKitapAd.Text = t.ALKITAPAD;
        }

        private void BtnGuncellle_Click(object sender, EventArgs e)
        {
            if (TxtAlKitapAd.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ALKITAPID"));
                TxtAlKitapID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_ALINACAK.Find(id);
                t.ALKITAPAD = TxtAlKitapAd.Text.ToUpper();
                de.SaveChanges();
                MessageBox.Show("Alınacak Kitap başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (TxtAlKitapAd.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ALKITAPID"));
                TxtAlKitapID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_ALINACAK.Find(id);
                de.TBL_ALINACAK.Remove(t);
                de.SaveChanges();
                MessageBox.Show("Alınacak Kitap başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
