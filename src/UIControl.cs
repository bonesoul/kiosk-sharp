using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace kiosksharp
{
    public static class UIControl // controls the main user interface
    {
        public static int SCROLL_RATIO; // calculated scroll ratio. Check calculate_scrollbar_ratio()
        private static int SCROLLBAR_MAX = 75;

        public static void UI_Load() // fires when the main form starts up
        {
            try
            {
                UIControl.resize_flash_control();

                // position the keyboard flash control - docked at bottom
                Program.MainForm.flash_keyboard.Height = 225;
                Program.MainForm.flash_keyboard.Width = Program.MainForm.Width;
                Program.MainForm.flash_keyboard.Dock = System.Windows.Forms.DockStyle.Bottom;

                // reposition webbroswer so it does not overlap the scrollbar
                Program.MainForm.webbrowser.Left = 0;
                Program.MainForm.webbrowser.Top = 0;
                Program.MainForm.webbrowser.ScrollBarsEnabled = false; // disable scrollbars by default
                Program.MainForm.webbrowser.Width = Program.MainForm.Width - Program.MainForm.webbrowser_scroll.Width - 3;
                Program.MainForm.webbrowser.Height = Program.MainForm.Height - Program.MainForm.flash_keyboard.Height;

                // As this is a touch screen aplication, scrollbar must be touchable so that a default value of 100 is used. Check calculate_scrollbar_ratio()
                Program.MainForm.webbrowser_scroll.Maximum = SCROLLBAR_MAX + 25; // +25 is the fallback value for scrollbar
                
                // load the startup movie
                if ((bool)Properties.Settings.Default["disable_intro"] == true) // disable the intro movie
                    UIManager.render_ui(UIManager.UIAction.MENU, KioskMenu.root_menu);
                else
                    UIManager.render_ui(UIManager.UIAction.INTRO, null);
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        public static void resize_flash_control()
        {
            // position the main movie flash control - maximize it
            Program.MainForm.flash_control.Left = 0;
            Program.MainForm.flash_control.Top = 0;
            Program.MainForm.flash_control.Width = Program.MainForm.Width;
            Program.MainForm.flash_control.Height = Program.MainForm.Height;
            Program.MainForm.flash_control.Quality = 1;
            Program.MainForm.flash_control.Quality2 = "High";
            Program.MainForm.flash_control.ScaleMode = 2; // seems to have fullscreen scale
        }

        public static void prepare_movie_render()
        {
            try
            {
                // disable keyboard, webbrowser, scrollbar and enable the main flash control
                Program.MainForm.flash_keyboard.Visible = false;
                Program.MainForm.webbrowser.Visible = false;
                Program.MainForm.webbrowser_scroll.Visible = false;
                Program.MainForm.flash_control.Visible = true;

                Program.MainForm.progress_navigate.Visible = false; //  we may have progressbar visible, disable it when returning to menus
                Program.MainForm.progress_navigate.Properties.Stopped = true;
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        public static void prepare_webpage_render()
        {
            try
            {
                // render the flash keyboard movie
                UIManager.render_ui(UIManager.UIAction.KEYBOARD, null);

                // position the webbrowser scroll bar and set scrolling data
                Program.MainForm.webbrowser_scroll.Left = Program.MainForm.Width - Program.MainForm.webbrowser_scroll.Width;
                Program.MainForm.webbrowser_scroll.Top = 0;
                Program.MainForm.webbrowser_scroll.Height = Program.MainForm.webbrowser.Height;
                calculate_scrollbar_ratio(); // calculate the scrollbars ratio

                // enable keyboard control, webbrowser and webbrowser scrollbar
                Program.MainForm.flash_keyboard.Visible = true;
                Program.MainForm.webbrowser.Visible = true;

                //disable progressbar
                Program.MainForm.webbrowser_scroll.Visible = true;

                // disable main flash control
                Program.MainForm.flash_control.Visible = false;
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        public static void calculate_scrollbar_ratio() 
        {
            // As this is a touch screen application scrollbar must be able to touched and scrolled. 
            // So that a default maximum value of 100 is suitable for the control but we have to calculate a ratio in order to accomplish the scrolling function
            if (Program.MainForm.webbrowser.Document.Body != null)
            {
                int scroll_height = (Program.MainForm.webbrowser.Document.Body.ScrollRectangle.Height - Program.MainForm.webbrowser.Height + 100);
                SCROLL_RATIO = scroll_height / SCROLLBAR_MAX;
            }
        }

        public static void browser_navigation_start() // fires when browser starts navigating
        {
            Program.MainForm.progress_navigate.Left = 0;
            Program.MainForm.progress_navigate.Width = Program.MainForm.Width;
            Program.MainForm.progress_navigate.Top = Program.MainForm.Height - Program.MainForm.progress_navigate.Height;
            UIManager.NavigationCanceled = false;
            Program.MainForm.progress_navigate.Visible = true;
            Program.MainForm.progress_navigate.Properties.Stopped = false;
        }

        public static void browser_navigation_complete() // fires after browser finishes navigation
        {
            Program.MainForm.timer.Enabled = false; // disable the navigation timeout timer
            if (UIManager.NavigationCanceled == false)
            {
                UIControl.prepare_webpage_render();
                Program.MainForm.progress_navigate.Visible = false;
                Program.MainForm.progress_navigate.Properties.Stopped = true;
                Program.MainForm.webbrowser_scroll.Value = 0; // scrollback to top after navigation
                Program.MainForm.webbrowser.Document.Body.ScrollIntoView(true); // show the top of the html body
            }
        }
    }
}
