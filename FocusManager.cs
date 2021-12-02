using System.Collections.Generic;
using System.Windows.Forms;

namespace FocusMode
{
    public class FocusManager
    {
        private Dictionary<Screen, ViewBlocker> blockers = new Dictionary<Screen, ViewBlocker>();
        private Settings settings;

        public FocusManager(Settings settings) {
            this.settings = settings;
            foreach(Screen screen in Screen.AllScreens) {
                ViewBlocker blocker = new ViewBlocker(screen, this);
                blocker.Opacity = 0;
                blocker.Show();
                blocker.Visible = false;
                blockers.Add(screen, blocker);
            }
            SetOpacity(settings.GetOpacity());
        }

        public void Focus(Screen screen) {
            foreach (var blocker in blockers) {
                if (blocker.Key == screen) {
                    continue;
                }
                blocker.Value.Visible = true;
                blocker.Value.TopMost = true;
                blocker.Value.TopMost = false;
            }
        }

        public void HideFocus() {
            foreach (var blocker in blockers) {
                blocker.Value.Visible = false;
            }
            HideSettings();
        }

        public void SetOpacity(int opacity) {
            if (opacity > 100 || opacity < 0) {
                return;
            }
            foreach(var blocker in blockers) {
                blocker.Value.Opacity = (double) opacity / 100;
            }
        }

        public void ShowSettings(Screen screen) {
            settings.ShowSettings(screen);
        }

        public void HideSettings() {
            settings.HideSettings();
        }


    }
}
