using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FocusMode
{
	public partial class Settings : Form
    {
        private SortedDictionary<string, Screen> screens = new SortedDictionary<string, Screen>();
        private FocusManager manager;

        public Settings()
        {
            InitializeComponent();
            ReloadDisplays();
        }

        public void ShowSettings(Screen screen) {
            Visible = true;
            Opacity = 1;
            WindowState = FormWindowState.Normal;
            ResetWindowLocation(screen);
        }

        public void HideSettings() {
            Visible = false;
            Opacity = 0;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        public int GetOpacity() {
            return SliderOpacity.Value;
        }

        private void ReloadDisplays() {
            screens.Clear();
            manager?.HideFocus();
            // Delete cached screens
            typeof(Screen).GetField("screens", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, null);
            
            Screen[] allScreens = Screen.AllScreens;
            for (int i = 0; i < allScreens.Length; i++) {
                screens.Add("Display 0" + (i + 1), allScreens[i]);
            }
            ComboScreens.DataSource = new BindingSource(screens, null);
            ComboScreens.DisplayMember = "Key";
            ComboScreens.ValueMember = "Value";
            LoadProperties();
            manager = new FocusManager(this);
        }

        private void ResetWindowLocation(Screen screen)
        {
            StartPosition = FormStartPosition.Manual;
            Rectangle resolution = screen.Bounds;
			Point location = new Point(screen.WorkingArea.Left + resolution.Width - Width, screen.WorkingArea.Top + resolution.Height - Height);
            Location = location;
        }

        private Screen GetSelectedScreen() {
            ReloadDisplays();
            return ((KeyValuePair<string, Screen>) ComboScreens.SelectedItem).Value;
        }

        /// <summary>
        /// Settings dialog elements
        /// </summary>
        #region Settings Dialog Elements

        private void Settings_Load(object sender, EventArgs e) {
            if (screens.Count <= 1) {
                MessageBox.Show("Need at least two monitors for this application to work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Focus", MenuFocusMode);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Close", MenuClose);
            TrayIcon.ContextMenu = trayMenu;
            Screen selectedScreen = GetSelectedScreen();
            if (!CheckBoxMinimized.Checked) {
                manager.Focus(selectedScreen);
            }
            HideSettings();
        }

        private void MenuClose(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MenuFocusMode(object sender, EventArgs e) {
            Screen selectedScreen = GetSelectedScreen();
            manager.Focus(selectedScreen);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            LoadProperties();
            manager.SetOpacity(SliderOpacity.Value);
            HideSettings();
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
            Screen selectedScreen = GetSelectedScreen();
            manager.Focus(selectedScreen);
            manager.SetOpacity(SliderOpacity.Value);
            Visible = false;
        }

        private void SliderOpacity_Scroll(object sender, EventArgs e) {
            manager.SetOpacity(SliderOpacity.Value);
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            MenuFocusMode(sender, e);
        }

        private void ButtonAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(Properties.Resources.About, "About Focus Mode");
        }

        #endregion Settings Dialog Elements

        /// <summary>
        /// Loading and saving of Settings properties
        /// </summary>
        #region Properties

        private void LoadProperties()
        {
            SliderOpacity.Value = Properties.Settings.Default.Opacity;
            if (screens.Count < Properties.Settings.Default.Screen + 1) {
                ComboScreens.SelectedIndex = 0;
            } else {
                ComboScreens.SelectedIndex = Properties.Settings.Default.Screen;
            }
            CheckBoxMinimized.Checked = Properties.Settings.Default.Minimized;
        }

        private void SaveProperties()
        {
            Properties.Settings.Default.Opacity = SliderOpacity.Value;
            Properties.Settings.Default.Screen = ComboScreens.SelectedIndex;
            Properties.Settings.Default.Minimized = CheckBoxMinimized.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion Properties
    }
}
