using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusMode
{
    public partial class ViewBlocker : Form
    {

        Settings settings;

        public ViewBlocker(Settings settings) {
            InitializeComponent();
            this.settings = settings;
        }

        public void FocusMode(Screen screen) {
            ResetWindowLocation(screen);
            Visible = true;
        }

        private void ResetWindowLocation(Screen screen) {
            Width = screen.Bounds.Width;
            Height = screen.Bounds.Height;
            Point screenLocation = new Point();
            screenLocation.X = screen.WorkingArea.Left;
            screenLocation.Y = screen.WorkingArea.Top;
            Location = screenLocation;
            WindowState = FormWindowState.Normal;
        }

        private void ViewBlocker_Load(object sender, EventArgs e) {
            settings.Visible = false;
        }

        private void ViewBlocker_Click(object sender, EventArgs e) {
            this.Visible = false;
            settings.Visible = false;
        }

        private void ButtonSettings_Click(object sender, EventArgs e) {
            settings.ShowSettings();
        }

        private void ButtonSettings_MouseEnter(object sender, EventArgs e) {
            ButtonSettings.BackgroundImage = Properties.Resources.cog_solid_active;
        }

        private void ButtonSettings_MouseLeave(object sender, EventArgs e) {
            ButtonSettings.BackgroundImage = Properties.Resources.cog_solid_normal;
        }

        private void ButtonClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e) {
            ButtonSettings.BackgroundImage = Properties.Resources.close_active;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e) {
            ButtonSettings.BackgroundImage = Properties.Resources.close_normal;
        }
    }
}
