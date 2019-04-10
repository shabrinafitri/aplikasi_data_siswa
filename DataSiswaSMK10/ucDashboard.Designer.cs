namespace DataSiswaSMK10
{
    partial class ucDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtAP = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.mtAK = new MetroFramework.Controls.MetroTile();
            this.mtPM = new MetroFramework.Controls.MetroTile();
            this.mtRPL = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtAP
            // 
            this.mtAP.ActiveControl = null;
            this.mtAP.Location = new System.Drawing.Point(139, 93);
            this.mtAP.Name = "mtAP";
            this.mtAP.Size = new System.Drawing.Size(200, 200);
            this.mtAP.TabIndex = 0;
            this.mtAP.Text = "AP";
            this.mtAP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAP.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(139, 299);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(818, 300);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "SMK NEGERI 10 JAKARTA";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.UseSelectable = true;
            // 
            // mtAK
            // 
            this.mtAK.ActiveControl = null;
            this.mtAK.Location = new System.Drawing.Point(345, 93);
            this.mtAK.Name = "mtAK";
            this.mtAK.Size = new System.Drawing.Size(200, 200);
            this.mtAK.TabIndex = 2;
            this.mtAK.Text = "AK";
            this.mtAK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAK.UseSelectable = true;
            // 
            // mtPM
            // 
            this.mtPM.ActiveControl = null;
            this.mtPM.Location = new System.Drawing.Point(551, 93);
            this.mtPM.Name = "mtPM";
            this.mtPM.Size = new System.Drawing.Size(200, 200);
            this.mtPM.TabIndex = 3;
            this.mtPM.Text = "PM";
            this.mtPM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPM.UseSelectable = true;
            // 
            // mtRPL
            // 
            this.mtRPL.ActiveControl = null;
            this.mtRPL.Location = new System.Drawing.Point(757, 93);
            this.mtRPL.Name = "mtRPL";
            this.mtRPL.Size = new System.Drawing.Size(200, 200);
            this.mtRPL.TabIndex = 4;
            this.mtRPL.Text = "RPL";
            this.mtRPL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRPL.UseSelectable = true;
            this.mtRPL.Click += new System.EventHandler(this.mtRPL_Click);
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtRPL);
            this.Controls.Add(this.mtPM);
            this.Controls.Add(this.mtAK);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtAP);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1154, 694);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAP;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile mtAK;
        private MetroFramework.Controls.MetroTile mtPM;
        private MetroFramework.Controls.MetroTile mtRPL;
    }
}
