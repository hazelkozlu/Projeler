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
    public partial class FrmTurler : Form
    {
        public FrmTurler()
        {
            InitializeComponent();
        }
        void Listele()
        {
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var query = from item in de.TBL_TURLER
                        select new
                        {
                            item.TURID,
                            item.TURAD
                        };
            gridControl1.DataSource = query.ToList();
        }
        void Temizle()
        {
            TxtTurID.Text = "";
            TxtTurAd.Text = "";


        }
        private void FrmTurler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtTurAd.Text != "")
            {
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                TBL_TURLER t = new TBL_TURLER();
                t.TURAD = TxtTurAd.Text.ToUpper();
                de.TBL_TURLER.Add(t);
                de.SaveChanges();
                MessageBox.Show("Kitap Türü başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("TURID"));
            TxtTurID.Text = id.ToString();
            KutuphaneDBEntities de = new KutuphaneDBEntities();
            var t = de.TBL_TURLER.Find(id);
            TxtTurAd.Text = t.TURAD;
        }

        private void BtnGuncellle_Click(object sender, EventArgs e)
        {
            if (TxtTurAd.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("TURID"));
                TxtTurID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_TURLER.Find(id);
                t.TURAD = TxtTurAd.Text.ToUpper();
                de.SaveChanges();
                MessageBox.Show("Kitap Türü başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (TxtTurAd.Text != "")
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("TURID"));
                TxtTurID.Text = id.ToString();
                KutuphaneDBEntities de = new KutuphaneDBEntities();
                var t = de.TBL_TURLER.Find(id);
                de.TBL_TURLER.Remove(t);
                de.SaveChanges();
                MessageBox.Show("Kitap Türü başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
