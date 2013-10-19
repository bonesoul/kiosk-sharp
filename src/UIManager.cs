using System;
using System.Collections.Generic;
using System.Text;

namespace kiosksharp
{
	public static class UIManager // Movie Manager - The main business logic lies here
	{
        public enum UIAction // Avaible acions
        {
            INTRO,
            MENU,
            KEYBOARD,
            LOADING,
            PRELOAD_MOVIE,
            WEBPAGE
        }

        public static item current_menu_item; // current menu item
        public static item timeout_item; // item that will be showed if system timeouts
        public static Boolean NavigationCanceled = false;

        public static void render_ui(UIAction action,item _item) // renders a give UI action
        {
            try
            {
                switch (action)
                {
                    case UIAction.INTRO:    // intro movie
                        render_intro();
                        break;
                    case UIAction.MENU: // menu movie
                        render_menu(_item);
                        break;
                    case UIAction.LOADING: // loading movie
                        render_loading_movie();
                        break;
                    case UIAction.PRELOAD_MOVIE: // preload movie
                        render_preload_movie(_item);
                        break;
                    case UIAction.KEYBOARD: // keyboard movie
                        render_keyboard();
                        break;
                    case UIAction.WEBPAGE: // web URL
                        render_page(_item);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        private static void render_keyboard() // render the keyboard movie
        {
            Program.MainForm.flash_keyboard.LoadMovie(0, Utils.get_movie_path(Utils.movie.keyboard));
        }

        private static void render_intro() // render intro
        {
            Program.MainForm.flash_control.LoadMovie(0, Utils.get_movie_path(Utils.movie.intro));
            UIControl.resize_flash_control();
        }

        private static void render_menu(item t) // render given menu
        {
            Program.MainForm.timer.Enabled = false; // a previous preload movie may be counting, if so disable it

            // first set to loading movie so that the variables set can be reset
            Program.MainForm.flash_control.LoadMovie(0, Utils.get_movie_path(Utils.movie.loading));
            UIControl.prepare_movie_render(); // prepare controls for movie rendering
            Program.MainForm.flash_control.LoadMovie(0, Utils.get_movie_path(Utils.movie.menu));
            UIControl.resize_flash_control();

            current_menu_item = t; // current rendered menu item
            
            // prepare variables to sent to flash movie
            // for each menu_item, a label and a visible variable is sent
            // label1,visible1, label2,visible2..
            int i = 1;
            foreach (item c in t.childs)
            {
                Program.MainForm.flash_control.SetVariable("label" + i, c.name);
                Program.MainForm.flash_control.SetVariable("visible" + i, "1");
                i++;
            } // set the variables

            // process the back button; for root menu do not show it
            if (t != KioskMenu.root_menu)
                Program.MainForm.flash_control.SetVariable("visible_back", "1");

            // notify the flash movie with function load_menu() that we set the required variables
            Program.MainForm.flash_control.CallFunction("<invoke name=\"load_menu\" returntype=\"xml\"></invoke>"); 
        }

        private static void render_preload_movie(item t) // render preload movie of the given item
        {
            current_menu_item = t; // set the current item
            Program.MainForm.timer.Interval = (int)Properties.Settings.Default["preload_movie_timeout"] * 1000; // run timer for preload movies timeouts
            Program.MainForm.timer.Tick += new EventHandler(preload_movie_timeout); // if it timeout's
            Program.MainForm.flash_control.LoadMovie(0, Utils.get_movie_path(t.preload_movie)); // render it's defined movie
            UIControl.resize_flash_control();
            Program.MainForm.timer.Enabled = true;
        }

        public static void preload_movie_timeout(object sender, EventArgs e) // fires when the preload timeout occurs
        {
            Program.MainForm.timer.Enabled = false;
            render_ui(UIAction.MENU, KioskMenu.root_menu); // if timeouts, render the main menu
        }

        public static void navigation_timeout(object sender, EventArgs e) // if navigation timeouts 
        {
            Program.MainForm.timer.Enabled = false;
            Program.MainForm.webbrowser.Stop(); // stop the navigation
            render_ui(UIAction.MENU, timeout_item); // return to previous menu
        }

        private static void render_page(item t)  // render given item's set URL
        {
            timeout_item = t.parent; // if navigation timeouts returns to parent menu
            // first we navigate using the browser, meanwhile we show the user loading screen. when page render is complete we show the page
            Program.MainForm.webbrowser.Navigate(t.url); // navigate url
            render_ui(UIAction.LOADING, null); // render loading movie while browser navigates the URL
        }

        private static void render_loading_movie() // render loading movie
        {
            Program.MainForm.timer.Interval = (int)Properties.Settings.Default["navigation_timeout"] * 1000; // navigation timeout
            Program.MainForm.timer.Tick += new EventHandler(navigation_timeout); 
            Program.MainForm.flash_control.LoadMovie(0, Utils.get_movie_path(Utils.movie.loading));
            UIControl.resize_flash_control();
            Program.MainForm.timer.Enabled = true;
        }
	}
}
