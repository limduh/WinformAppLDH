namespace MainForm
{
    partial class M03_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M03_MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsFormName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSearch = new System.Windows.Forms.ToolStripButton();
            this.tsInsert = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.M_TEST = new System.Windows.Forms.ToolStripMenuItem();
            this.Form001_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.Form002_Test2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tEST2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.g2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsFormName,
            this.toolStripStatusLabel2,
            this.stsUserName,
            this.stsNowTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsFormName
            // 
            this.stsFormName.AutoSize = false;
            this.stsFormName.Name = "stsFormName";
            this.stsFormName.Size = new System.Drawing.Size(200, 17);
            this.stsFormName.Text = "Form Name";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // stsUserName
            // 
            this.stsUserName.AutoSize = false;
            this.stsUserName.Name = "stsUserName";
            this.stsUserName.Size = new System.Drawing.Size(150, 17);
            this.stsUserName.Text = "User Name";
            // 
            // stsNowTime
            // 
            this.stsNowTime.AutoSize = false;
            this.stsNowTime.Name = "stsNowTime";
            this.stsNowTime.Size = new System.Drawing.Size(200, 17);
            this.stsNowTime.Text = "Now Date";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSearch,
            this.tsInsert,
            this.tsDelete,
            this.tsSave,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsClose,
            this.tsExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 100);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSearch
            // 
            this.tsSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsSearch.Image")));
            this.tsSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(54, 97);
            this.tsSearch.Text = "조회";
            this.tsSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsInsert
            // 
            this.tsInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsInsert.Image")));
            this.tsInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInsert.Name = "tsInsert";
            this.tsInsert.Size = new System.Drawing.Size(54, 97);
            this.tsInsert.Text = "추가";
            this.tsInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsDelete
            // 
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(54, 97);
            this.tsDelete.Text = "삭제";
            this.tsDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsSave
            // 
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(54, 97);
            this.tsSave.Text = "저장";
            this.tsSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 100);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 100);
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(54, 97);
            this.tsClose.Text = "닫기";
            this.tsClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsExit
            // 
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(54, 97);
            this.tsExit.Text = "종료";
            this.tsExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_TEST,
            this.tEST2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // M_TEST
            // 
            this.M_TEST.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Form001_Test,
            this.Form002_Test2});
            this.M_TEST.Name = "M_TEST";
            this.M_TEST.Size = new System.Drawing.Size(44, 20);
            this.M_TEST.Text = "TEST";
            // 
            // Form001_Test
            // 
            this.Form001_Test.Name = "Form001_Test";
            this.Form001_Test.Size = new System.Drawing.Size(145, 22);
            this.Form001_Test.Text = "테스트화면 1";
            // 
            // Form002_Test2
            // 
            this.Form002_Test2.Name = "Form002_Test2";
            this.Form002_Test2.Size = new System.Drawing.Size(145, 22);
            this.Form002_Test2.Text = "테스트화면 2";
            // 
            // tEST2ToolStripMenuItem
            // 
            this.tEST2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ggToolStripMenuItem,
            this.g2ToolStripMenuItem});
            this.tEST2ToolStripMenuItem.Name = "tEST2ToolStripMenuItem";
            this.tEST2ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tEST2ToolStripMenuItem.Text = "TEST2";
            // 
            // ggToolStripMenuItem
            // 
            this.ggToolStripMenuItem.Name = "ggToolStripMenuItem";
            this.ggToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.ggToolStripMenuItem.Text = "g1";
            // 
            // g2ToolStripMenuItem
            // 
            this.g2ToolStripMenuItem.Name = "g2ToolStripMenuItem";
            this.g2ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.g2ToolStripMenuItem.Text = "g2";
            // 
            // M03_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "M03_MainForm";
            this.Text = "M03_MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.M03_MainForm_FormClosing);
            this.Load += new System.EventHandler(this.M03_MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsFormName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stsUserName;
        private System.Windows.Forms.ToolStripStatusLabel stsNowTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSearch;
        private System.Windows.Forms.ToolStripButton tsInsert;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem M_TEST;
        private System.Windows.Forms.ToolStripMenuItem Form001_Test;
        private System.Windows.Forms.ToolStripMenuItem Form002_Test2;
        private System.Windows.Forms.ToolStripMenuItem tEST2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem g2ToolStripMenuItem;
    }
}