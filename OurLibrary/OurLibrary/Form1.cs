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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmKitaplar fr;
        private void BtnKitaplar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmKitaplar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        FrmYazarlar frm;
        private void BtnYazarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm == null)
            {
                frm = new FrmYazarlar();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        FrmTurler frn;
        private void BtnTurler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frn == null)
            {
                frn = new FrmTurler();
                frn.MdiParent = this;
                frn.Show();
            }
        }
        FrmAlinacak fra;
        private void BtnAlinacak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fra == null)
            {
                fra = new FrmAlinacak();
                fra.MdiParent = this;
                fra.Show();
            }
        }

        private void BtnGrafikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }
    }
}
