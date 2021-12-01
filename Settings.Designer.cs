namespace FocusMode
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelScreen = new System.Windows.Forms.Label();
            this.LabelApplicationTitle = new System.Windows.Forms.Label();
            this.LabelOpacity = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Panel();
            this.PanelSeperator02 = new System.Windows.Forms.Panel();
            this.ComboScreens = new System.Windows.Forms.ComboBox();
            this.SliderOpacity = new System.Windows.Forms.TrackBar();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.CheckBoxMinimized = new System.Windows.Forms.CheckBox();
            this.LabelMinimized = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ButtonSave.Location = new System.Drawing.Point(302, 182);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(94, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save Settings";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelScreen
            // 
            this.LabelScreen.AutoSize = true;
            this.LabelScreen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelScreen.Location = new System.Drawing.Point(12, 54);
            this.LabelScreen.Name = "LabelScreen";
            this.LabelScreen.Size = new System.Drawing.Size(85, 13);
            this.LabelScreen.TabIndex = 100;
            this.LabelScreen.Text = "Hidden Screen:";
            // 
            // LabelApplicationTitle
            // 
            this.LabelApplicationTitle.AutoSize = true;
            this.LabelApplicationTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelApplicationTitle.Location = new System.Drawing.Point(12, 5);
            this.LabelApplicationTitle.Name = "LabelApplicationTitle";
            this.LabelApplicationTitle.Size = new System.Drawing.Size(130, 17);
            this.LabelApplicationTitle.TabIndex = 100;
            this.LabelApplicationTitle.Text = "Focus Mode Settings";
            this.LabelApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOpacity
            // 
            this.LabelOpacity.AutoSize = true;
            this.LabelOpacity.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LabelOpacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelOpacity.Location = new System.Drawing.Point(12, 91);
            this.LabelOpacity.Name = "LabelOpacity";
            this.LabelOpacity.Size = new System.Drawing.Size(49, 13);
            this.LabelOpacity.TabIndex = 100;
            this.LabelOpacity.Text = "Opacity:";
            // 
            // PanelTitle
            // 
            this.PanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTitle.Controls.Add(this.ButtonClose);
            this.PanelTitle.Controls.Add(this.LabelApplicationTitle);
            this.PanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(408, 30);
            this.PanelTitle.TabIndex = 100;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackgroundImage = global::FocusMode.Properties.Resources.close_normal;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonClose.Location = new System.Drawing.Point(383, 8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(14, 14);
            this.ButtonClose.TabIndex = 100;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_HoverEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_HoverLeave);
            // 
            // PanelSeperator02
            // 
            this.PanelSeperator02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSeperator02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelSeperator02.Location = new System.Drawing.Point(0, 166);
            this.PanelSeperator02.Name = "PanelSeperator02";
            this.PanelSeperator02.Size = new System.Drawing.Size(408, 2);
            this.PanelSeperator02.TabIndex = 100;
            // 
            // ComboScreens
            // 
            this.ComboScreens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ComboScreens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboScreens.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboScreens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ComboScreens.FormattingEnabled = true;
            this.ComboScreens.Location = new System.Drawing.Point(120, 51);
            this.ComboScreens.Name = "ComboScreens";
            this.ComboScreens.Size = new System.Drawing.Size(277, 21);
            this.ComboScreens.TabIndex = 1;
            this.ComboScreens.SelectedIndexChanged += new System.EventHandler(this.ComboScreens_SelectedIndexChanged);
            // 
            // SliderOpacity
            // 
            this.SliderOpacity.LargeChange = 10;
            this.SliderOpacity.Location = new System.Drawing.Point(120, 91);
            this.SliderOpacity.Maximum = 100;
            this.SliderOpacity.Minimum = 20;
            this.SliderOpacity.Name = "SliderOpacity";
            this.SliderOpacity.Size = new System.Drawing.Size(277, 45);
            this.SliderOpacity.SmallChange = 5;
            this.SliderOpacity.TabIndex = 2;
            this.SliderOpacity.TickFrequency = 5;
            this.SliderOpacity.Value = 90;
            this.SliderOpacity.Scroll += new System.EventHandler(this.SliderOpacity_Scroll);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Focus Mode";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ButtonAbout.Location = new System.Drawing.Point(12, 182);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(94, 23);
            this.ButtonAbout.TabIndex = 5;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // CheckBoxMinimized
            // 
            this.CheckBoxMinimized.AutoSize = true;
            this.CheckBoxMinimized.Location = new System.Drawing.Point(120, 130);
            this.CheckBoxMinimized.Name = "CheckBoxMinimized";
            this.CheckBoxMinimized.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxMinimized.TabIndex = 3;
            this.CheckBoxMinimized.UseVisualStyleBackColor = true;
            // 
            // LabelMinimized
            // 
            this.LabelMinimized.AutoSize = true;
            this.LabelMinimized.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LabelMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelMinimized.Location = new System.Drawing.Point(12, 130);
            this.LabelMinimized.Name = "LabelMinimized";
            this.LabelMinimized.Size = new System.Drawing.Size(89, 13);
            this.LabelMinimized.TabIndex = 109;
            this.LabelMinimized.Text = "Start minimized:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(408, 217);
            this.Controls.Add(this.LabelMinimized);
            this.Controls.Add(this.CheckBoxMinimized);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.SliderOpacity);
            this.Controls.Add(this.ComboScreens);
            this.Controls.Add(this.PanelSeperator02);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.LabelOpacity);
            this.Controls.Add(this.LabelScreen);
            this.Controls.Add(this.ButtonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelScreen;
        private System.Windows.Forms.Label LabelApplicationTitle;
        private System.Windows.Forms.Label LabelOpacity;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel ButtonClose;
        private System.Windows.Forms.Panel PanelSeperator02;
        private System.Windows.Forms.ComboBox ComboScreens;
        private System.Windows.Forms.TrackBar SliderOpacity;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.CheckBox CheckBoxMinimized;
        private System.Windows.Forms.Label LabelMinimized;
    }
}

