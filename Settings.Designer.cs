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
            this.LabelClientIdentifier = new System.Windows.Forms.Label();
            this.LabelApplicationTitle = new System.Windows.Forms.Label();
            this.LabelUpdateRate = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.PanelSeperator02 = new System.Windows.Forms.Panel();
            this.ComboScreens = new System.Windows.Forms.ComboBox();
            this.SliderOpacity = new System.Windows.Forms.TrackBar();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButtonClose = new System.Windows.Forms.Panel();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ButtonSave.Location = new System.Drawing.Point(303, 157);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(94, 23);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save Settings";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelClientIdentifier
            // 
            this.LabelClientIdentifier.AutoSize = true;
            this.LabelClientIdentifier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClientIdentifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelClientIdentifier.Location = new System.Drawing.Point(12, 54);
            this.LabelClientIdentifier.Name = "LabelClientIdentifier";
            this.LabelClientIdentifier.Size = new System.Drawing.Size(41, 13);
            this.LabelClientIdentifier.TabIndex = 100;
            this.LabelClientIdentifier.Text = "Screen";
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
            // LabelUpdateRate
            // 
            this.LabelUpdateRate.AutoSize = true;
            this.LabelUpdateRate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LabelUpdateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelUpdateRate.Location = new System.Drawing.Point(12, 91);
            this.LabelUpdateRate.Name = "LabelUpdateRate";
            this.LabelUpdateRate.Size = new System.Drawing.Size(49, 13);
            this.LabelUpdateRate.TabIndex = 100;
            this.LabelUpdateRate.Text = "Opacity:";
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
            // PanelSeperator02
            // 
            this.PanelSeperator02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelSeperator02.Location = new System.Drawing.Point(0, 142);
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
            this.ComboScreens.TabIndex = 105;
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
            this.SliderOpacity.TabIndex = 106;
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(408, 192);
            this.Controls.Add(this.SliderOpacity);
            this.Controls.Add(this.ComboScreens);
            this.Controls.Add(this.PanelSeperator02);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.LabelUpdateRate);
            this.Controls.Add(this.LabelClientIdentifier);
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
        private System.Windows.Forms.Label LabelClientIdentifier;
        private System.Windows.Forms.Label LabelApplicationTitle;
        private System.Windows.Forms.Label LabelUpdateRate;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel ButtonClose;
        private System.Windows.Forms.Panel PanelSeperator02;
        private System.Windows.Forms.ComboBox ComboScreens;
        private System.Windows.Forms.TrackBar SliderOpacity;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

