using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FocusMode
{
	public partial class Settings : Form
    {

        private SortedDictionary<string, Screen> screens = new SortedDictionary<string, Screen>();
        private ViewBlocker viewBlocker;

        public Settings()
        {
            InitializeComponent();
            viewBlocker = new ViewBlocker(this);
            Screen[] allScreens = Screen.AllScreens;
            for (int i = 0; i < allScreens.Length; i++) {
                screens.Add("Diplay 0" + (i + 1), allScreens[i]);
            }
            ComboScreens.DataSource = new BindingSource(screens, null);
            ComboScreens.DisplayMember = "Key";
            ComboScreens.ValueMember = "Value";
        }

        public void ShowSettings()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            Screen selectedScreen = ((KeyValuePair<string, Screen>) ComboScreens.SelectedItem).Value;
            ResetWindowLocation(selectedScreen);
        }

        private void ResetWindowLocation(Screen screen)
        {
            StartPosition = FormStartPosition.Manual;
            Rectangle resolution = screen.Bounds;
			Point location = new Point(screen.WorkingArea.Left + resolution.Width - Width, screen.WorkingArea.Top + resolution.Height - Height);
			Location = location;
		}

        /// <summary>
        /// Settings dialog elements
        /// </summary>
        #region Settings Dialog Elements

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadProperties();
            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Close", MenuClose);
            TrayIcon.ContextMenu = trayMenu;
            viewBlocker.Show();
            viewBlocker.Visible = true;
            viewBlocker.Opacity = (double) SliderOpacity.Value / 100;
            Screen selectedScreen = ((KeyValuePair<string, Screen>) ComboScreens.SelectedItem).Value;
            ResetWindowLocation(selectedScreen);
            viewBlocker.FocusMode(selectedScreen);
        }

        private void MenuClose(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            LoadProperties();
            viewBlocker.Opacity = (double) SliderOpacity.Value / 100;
            Visible = false;
        }

		private void ButtonClose_HoverEnter(object sender, EventArgs e)
        {
			ButtonClose.BackgroundImage = Properties.Resources.close_active;
		}

		private void ButtonClose_HoverLeave(object sender, EventArgs e)
        {
			ButtonClose.BackgroundImage = Properties.Resources.close_normal;
		}

		private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveProperties();
            Screen selectedScreen = ((KeyValuePair<string, Screen>) ComboScreens.SelectedItem).Value;
            ResetWindowLocation(selectedScreen);
            viewBlocker.FocusMode(selectedScreen);
            Visible = false;
        }

        #endregion Settings Dialog Elements

        /// <summary>
        /// Loading and saving of Settings properties
        /// </summary>
        #region Properties

        private void LoadProperties()
        {
            SliderOpacity.Value = Properties.Settings.Default.Opacity;
            ComboScreens.SelectedIndex = Properties.Settings.Default.Screen;
        }

        private void SaveProperties()
        {
            Properties.Settings.Default.Opacity = SliderOpacity.Value;
            Properties.Settings.Default.Screen = ComboScreens.SelectedIndex;
            viewBlocker.Opacity = (double) SliderOpacity.Value / 100;
            Screen selectedScreen = ((KeyValuePair<string, Screen>) ComboScreens.SelectedItem).Value;
            ResetWindowLocation(selectedScreen);
            viewBlocker.FocusMode(selectedScreen);
            Properties.Settings.Default.Save();
        }

        #endregion Properties

        private void SliderOpacity_Scroll(object sender, EventArgs e) {
            viewBlocker.Opacity = (double) SliderOpacity.Value / 100;
        }

        private void ComboScreens_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            viewBlocker.Visible = !viewBlocker.Visible;
        }

        private void ButtonAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(Properties.Resources.About, "About Focus Mode");
        }
    }
}
