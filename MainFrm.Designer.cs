namespace LicenseKeyGenerator
{
    partial class MainFrm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxKeys = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxKeys);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 426);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Keys";
            // 
            // listBoxKeys
            // 
            this.listBoxKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKeys.FormattingEnabled = true;
            this.listBoxKeys.Location = new System.Drawing.Point(3, 16);
            this.listBoxKeys.Name = "listBoxKeys";
            this.listBoxKeys.Size = new System.Drawing.Size(794, 407);
            this.listBoxKeys.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pieceToolStripMenuItem,
            this.pieceToolStripMenuItem1,
            this.pieceToolStripMenuItem2,
            this.pieceToolStripMenuItem3,
            this.pieceToolStripMenuItem4,
            this.pieceToolStripMenuItem5});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pieceToolStripMenuItem
            // 
            this.pieceToolStripMenuItem.Name = "pieceToolStripMenuItem";
            this.pieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pieceToolStripMenuItem.Text = "1 Piece";
            this.pieceToolStripMenuItem.Click += new System.EventHandler(this.pieceToolStripMenuItem_Click);
            // 
            // pieceToolStripMenuItem1
            // 
            this.pieceToolStripMenuItem1.Name = "pieceToolStripMenuItem1";
            this.pieceToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pieceToolStripMenuItem1.Text = "50 Piece";
            this.pieceToolStripMenuItem1.Click += new System.EventHandler(this.pieceToolStripMenuItem1_Click);
            // 
            // pieceToolStripMenuItem2
            // 
            this.pieceToolStripMenuItem2.Name = "pieceToolStripMenuItem2";
            this.pieceToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.pieceToolStripMenuItem2.Text = "100 Piece";
            this.pieceToolStripMenuItem2.Click += new System.EventHandler(this.pieceToolStripMenuItem2_Click);
            // 
            // pieceToolStripMenuItem3
            // 
            this.pieceToolStripMenuItem3.Name = "pieceToolStripMenuItem3";
            this.pieceToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.pieceToolStripMenuItem3.Text = "500 Piece";
            this.pieceToolStripMenuItem3.Click += new System.EventHandler(this.pieceToolStripMenuItem3_Click);
            // 
            // pieceToolStripMenuItem4
            // 
            this.pieceToolStripMenuItem4.Name = "pieceToolStripMenuItem4";
            this.pieceToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.pieceToolStripMenuItem4.Text = "1000 Piece";
            this.pieceToolStripMenuItem4.Click += new System.EventHandler(this.pieceToolStripMenuItem4_Click);
            // 
            // pieceToolStripMenuItem5
            // 
            this.pieceToolStripMenuItem5.Name = "pieceToolStripMenuItem5";
            this.pieceToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.pieceToolStripMenuItem5.Text = "5000 Piece";
            this.pieceToolStripMenuItem5.Click += new System.EventHandler(this.pieceToolStripMenuItem5_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = global::LicenseKeyGenerator.Properties.Resources.Icon;
            this.Text = "License Key Generator";
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxKeys;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

