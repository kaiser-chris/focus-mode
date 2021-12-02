using System;
using System.Drawing;
using System.Windows.Forms;

namespace FocusMode
{
    public partial class ViewBlocker : Form
    {
        FocusManager manager;
        Screen screen;

        public ViewBlocker(Screen screen, FocusManager manager) {
            InitializeComponent();
            this.screen = screen;
            this.manager = manager;
            ResetWindowLocation(screen);
        }

        private void ResetWindowLocation(Screen screen) {
            WindowState = FormWindowState.Normal;
            Width = screen.Bounds.Width;
            Height = screen.Bounds.Height;
            Point screenLocation = new Point {
                X = screen.WorkingArea.Left,
                Y = screen.WorkingArea.Top
            };
            Location = screenLocation;
        }

        private void ViewBlocker_Click(object sender, EventArgs e) {
            manager.HideFocus();
        }

        private void ButtonSettings_Click(object sender, EventArgs e) {
            manager.ShowSettings(screen);
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
