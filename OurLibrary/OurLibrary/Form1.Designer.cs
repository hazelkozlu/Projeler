namespace OurLibrary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnKitaplar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnYazarlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTurler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAlinacak = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnKitaplar,
            this.BtnYazarlar,
            this.BtnTurler,
            this.BtnAlinacak});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1200, 141);
            // 
            // BtnKitaplar
            // 
            this.BtnKitaplar.Caption = "KİTAPLAR";
            this.BtnKitaplar.Id = 1;
            this.BtnKitaplar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitaplar.ImageOptions.Image")));
            this.BtnKitaplar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKitaplar.ImageOptions.LargeImage")));
            this.BtnKitaplar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitaplar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKitaplar.Name = "BtnKitaplar";
            this.BtnKitaplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKitaplar_ItemClick);
            // 
            // BtnYazarlar
            // 
            this.BtnYazarlar.Caption = "YAZARLAR";
            this.BtnYazarlar.Id = 2;
            this.BtnYazarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnYazarlar.ImageOptions.Image")));
            this.BtnYazarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnYazarlar.ImageOptions.LargeImage")));
            this.BtnYazarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYazarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnYazarlar.Name = "BtnYazarlar";
            this.BtnYazarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnYazarlar_ItemClick);
            // 
            // BtnTurler
            // 
            this.BtnTurler.Caption = "TÜRLER";
            this.BtnTurler.Id = 3;
            this.BtnTurler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTurler.ImageOptions.Image")));
            this.BtnTurler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTurler.ImageOptions.LargeImage")));
            this.BtnTurler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTurler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnTurler.Name = "BtnTurler";
            this.BtnTurler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTurler_ItemClick);
            // 
            // BtnAlinacak
            // 
            this.BtnAlinacak.Caption = "ALINACAKLAR";
            this.BtnAlinacak.Id = 4;
            this.BtnAlinacak.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlinacak.ImageOptions.Image")));
            this.BtnAlinacak.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAlinacak.ImageOptions.LargeImage")));
            this.BtnAlinacak.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlinacak.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAlinacak.Name = "BtnAlinacak";
            this.BtnAlinacak.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAlinacak_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kütüphanemiz";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKitaplar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnYazarlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnTurler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAlinacak);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnKitaplar;
        private DevExpress.XtraBars.BarButtonItem BtnYazarlar;
        private DevExpress.XtraBars.BarButtonItem BtnTurler;
        private DevExpress.XtraBars.BarButtonItem BtnAlinacak;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

