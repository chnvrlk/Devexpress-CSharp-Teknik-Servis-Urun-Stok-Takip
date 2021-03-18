namespace TeknikServis.Formlar
{
    partial class FrmAnasayfa
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
            this.gridKritik = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpKritik = new DevExpress.XtraEditors.GroupControl();
            this.grpFihrist = new DevExpress.XtraEditors.GroupControl();
            this.gridFih = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpKategoriUrun = new DevExpress.XtraEditors.GroupControl();
            this.gridUrunKate = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpBugunYap = new DevExpress.XtraEditors.GroupControl();
            this.gridBugunYap = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridKritik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKritik)).BeginInit();
            this.grpKritik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFihrist)).BeginInit();
            this.grpFihrist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKategoriUrun)).BeginInit();
            this.grpKategoriUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunKate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBugunYap)).BeginInit();
            this.grpBugunYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBugunYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKritik
            // 
            this.gridKritik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKritik.Location = new System.Drawing.Point(2, 20);
            this.gridKritik.MainView = this.gridView1;
            this.gridKritik.Name = "gridKritik";
            this.gridKritik.Size = new System.Drawing.Size(671, 258);
            this.gridKritik.TabIndex = 15;
            this.gridKritik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridKritik;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grpKritik
            // 
            this.grpKritik.Controls.Add(this.gridKritik);
            this.grpKritik.Location = new System.Drawing.Point(3, 2);
            this.grpKritik.Name = "grpKritik";
            this.grpKritik.Size = new System.Drawing.Size(675, 280);
            this.grpKritik.TabIndex = 18;
            this.grpKritik.Text = "Kritik Seviye";
            // 
            // grpFihrist
            // 
            this.grpFihrist.Controls.Add(this.gridFih);
            this.grpFihrist.Location = new System.Drawing.Point(686, 2);
            this.grpFihrist.Name = "grpFihrist";
            this.grpFihrist.Size = new System.Drawing.Size(675, 280);
            this.grpFihrist.TabIndex = 19;
            this.grpFihrist.Text = "Fihrist";
            // 
            // gridFih
            // 
            this.gridFih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFih.Location = new System.Drawing.Point(2, 20);
            this.gridFih.MainView = this.gridView2;
            this.gridFih.Name = "gridFih";
            this.gridFih.Size = new System.Drawing.Size(671, 258);
            this.gridFih.TabIndex = 15;
            this.gridFih.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridFih;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // grpKategoriUrun
            // 
            this.grpKategoriUrun.Controls.Add(this.gridUrunKate);
            this.grpKategoriUrun.Location = new System.Drawing.Point(3, 288);
            this.grpKategoriUrun.Name = "grpKategoriUrun";
            this.grpKategoriUrun.Size = new System.Drawing.Size(675, 280);
            this.grpKategoriUrun.TabIndex = 20;
            this.grpKategoriUrun.Text = "Kategori-Urun";
            // 
            // gridUrunKate
            // 
            this.gridUrunKate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunKate.Location = new System.Drawing.Point(2, 20);
            this.gridUrunKate.MainView = this.gridView3;
            this.gridUrunKate.Name = "gridUrunKate";
            this.gridUrunKate.Size = new System.Drawing.Size(671, 258);
            this.gridUrunKate.TabIndex = 15;
            this.gridUrunKate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.GridControl = this.gridUrunKate;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // grpBugunYap
            // 
            this.grpBugunYap.Controls.Add(this.gridBugunYap);
            this.grpBugunYap.Location = new System.Drawing.Point(687, 288);
            this.grpBugunYap.Name = "grpBugunYap";
            this.grpBugunYap.Size = new System.Drawing.Size(675, 280);
            this.grpBugunYap.TabIndex = 21;
            this.grpBugunYap.Text = "Bugün Yapılacaklar";
            // 
            // gridBugunYap
            // 
            this.gridBugunYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBugunYap.Location = new System.Drawing.Point(2, 20);
            this.gridBugunYap.MainView = this.gridView4;
            this.gridBugunYap.Name = "gridBugunYap";
            this.gridBugunYap.Size = new System.Drawing.Size(671, 258);
            this.gridBugunYap.TabIndex = 15;
            this.gridBugunYap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.GridControl = this.gridBugunYap;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1365, 572);
            this.Controls.Add(this.grpBugunYap);
            this.Controls.Add(this.grpKategoriUrun);
            this.Controls.Add(this.grpFihrist);
            this.Controls.Add(this.grpKritik);
            this.Name = "FrmAnasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKritik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKritik)).EndInit();
            this.grpKritik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFihrist)).EndInit();
            this.grpFihrist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKategoriUrun)).EndInit();
            this.grpKategoriUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunKate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBugunYap)).EndInit();
            this.grpBugunYap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBugunYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKritik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpKritik;
        private DevExpress.XtraEditors.GroupControl grpFihrist;
        private DevExpress.XtraGrid.GridControl gridFih;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl grpKategoriUrun;
        private DevExpress.XtraGrid.GridControl gridUrunKate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl grpBugunYap;
        private DevExpress.XtraGrid.GridControl gridBugunYap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}