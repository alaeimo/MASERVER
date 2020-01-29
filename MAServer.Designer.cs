namespace MAServer
{
    partial class MAServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAServer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.NetworkNameLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.IP_PORTLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.FileTabPage = new System.Windows.Forms.TabPage();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.FilesTextBox = new System.Windows.Forms.TextBox();
            this.UsersTabPage = new System.Windows.Forms.TabPage();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FileTabPage.SuspendLayout();
            this.UsersTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chartreuse;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DeviceNameLabel);
            this.panel1.Controls.Add(this.NetworkNameLabel);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.IPLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 532);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 108);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.DeviceNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceNameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.DeviceNameLabel.Location = new System.Drawing.Point(140, 76);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(158, 35);
            this.DeviceNameLabel.TabIndex = 4;
            this.DeviceNameLabel.Text = "Device Name: ";
            // 
            // NetworkNameLabel
            // 
            this.NetworkNameLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.NetworkNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetworkNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkNameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.NetworkNameLabel.Location = new System.Drawing.Point(140, 3);
            this.NetworkNameLabel.Name = "NetworkNameLabel";
            this.NetworkNameLabel.Size = new System.Drawing.Size(158, 35);
            this.NetworkNameLabel.TabIndex = 7;
            this.NetworkNameLabel.Text = "Network Name: ";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.GreenYellow;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(0, 378);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(306, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start ";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(62, 325);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(178, 23);
            this.IPLabel.TabIndex = 5;
            this.IPLabel.Text = "IP/PORT:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(62, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 146);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 114);
            this.label1.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Bisque;
            this.StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatusLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(-1, 508);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(308, 24);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Server Started!";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // IP_PORTLabel
            // 
            this.IP_PORTLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.IP_PORTLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_PORTLabel.Location = new System.Drawing.Point(-1, 24);
            this.IP_PORTLabel.Name = "IP_PORTLabel";
            this.IP_PORTLabel.Size = new System.Drawing.Size(227, 23);
            this.IP_PORTLabel.TabIndex = 10;
            this.IP_PORTLabel.Text = "IP/PORT: ";
            this.IP_PORTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(226, 24);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(81, 23);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Stop";
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FileTabPage
            // 
            this.FileTabPage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.FileTabPage.Controls.Add(this.AddFileButton);
            this.FileTabPage.Controls.Add(this.FilesTextBox);
            this.FileTabPage.Location = new System.Drawing.Point(4, 22);
            this.FileTabPage.Name = "FileTabPage";
            this.FileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FileTabPage.Size = new System.Drawing.Size(306, 439);
            this.FileTabPage.TabIndex = 0;
            this.FileTabPage.Text = "Files";
            // 
            // AddFileButton
            // 
            this.AddFileButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddFileButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFileButton.Location = new System.Drawing.Point(251, 1);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(35, 20);
            this.AddFileButton.TabIndex = 1;
            this.AddFileButton.Text = "Add";
            this.AddFileButton.UseVisualStyleBackColor = false;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // FilesTextBox
            // 
            this.FilesTextBox.Location = new System.Drawing.Point(2, 1);
            this.FilesTextBox.Name = "FilesTextBox";
            this.FilesTextBox.Size = new System.Drawing.Size(249, 20);
            this.FilesTextBox.TabIndex = 0;
            // 
            // UsersTabPage
            // 
            this.UsersTabPage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.UsersTabPage.Controls.Add(this.RefreshBtn);
            this.UsersTabPage.Location = new System.Drawing.Point(4, 22);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTabPage.Size = new System.Drawing.Size(306, 439);
            this.UsersTabPage.TabIndex = 1;
            this.UsersTabPage.Text = "Users";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshBtn.Location = new System.Drawing.Point(1, 1);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(304, 25);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.UsersTabPage);
            this.TabControl.Controls.Add(this.FileTabPage);
            this.TabControl.Location = new System.Drawing.Point(-4, 50);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(314, 465);
            this.TabControl.TabIndex = 1;
            // 
            // MAServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.IP_PORTLabel);
            this.Controls.Add(this.StopButton);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(322, 572);
            this.Name = "MAServer";
            this.Text = "βeta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FileTabPage.ResumeLayout(false);
            this.FileTabPage.PerformLayout();
            this.UsersTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label NetworkNameLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label IP_PORTLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TabPage FileTabPage;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.TextBox FilesTextBox;
        private System.Windows.Forms.TabPage UsersTabPage;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TabControl TabControl;
    }
}

