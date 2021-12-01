
namespace FocusMode
{
    partial class ViewBlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBlocker));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = global::FocusMode.Properties.Resources.close_normal;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonClose.Location = new System.Drawing.Point(780, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(20, 20);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSettings.BackgroundImage = global::FocusMode.Properties.Resources.cog_solid_normal;
            this.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonSettings.Location = new System.Drawing.Point(780, 430);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(20, 20);
            this.ButtonSettings.TabIndex = 0;
            this.ButtonSettings.TabStop = false;
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            this.ButtonSettings.MouseEnter += new System.EventHandler(this.ButtonSettings_MouseEnter);
            this.ButtonSettings.MouseLeave += new System.EventHandler(this.ButtonSettings_MouseLeave);
            // 
            // ViewBlocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewBlocker";
            this.Opacity = 0.6D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View Blocker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewBlocker_Load);
            this.Click += new System.EventHandler(this.ViewBlocker_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonClose;
    }
}

