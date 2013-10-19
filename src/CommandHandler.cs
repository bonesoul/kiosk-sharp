using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace kiosksharp
{
    public static class CommandHandler
    {
        public static string developer_buffer;

        public static void handle(string cmd, string args) // handle all the FSCommands
        {
            if (args.ToLower() == "<p align=\"left\"></p>")
                return; // flash may return fscommand for blank animated buttons. just ignore them

            switch (cmd.ToLower())
            {
                case "button_click": // button_click from main MenuMovie
                    flash_button_click(args.ToLower());
                    break;
                case "preload": // user clicked continue on Preload movie
                    if (args.ToLower() == "devam")
                    {
                        flash_preload_continue();
                    }
                    break;
                case "klavye": // keyboard command
                    flash_keyboard_click(args);
                    break;
                case "intro": // intro complete
                    if (args.ToLower() == "complete")
                        UIManager.render_ui(UIManager.UIAction.MENU, KioskMenu.root_menu); // render the main menu after intro is complete
                    break;
                default:
                    break;
            }
        }

        private static void flash_keyboard_click(string key)
        {
            if (key.ToLower() == "anamenu") // this not a key, instead a command to return the main main
            {
                UIManager.render_ui(UIManager.UIAction.MENU, KioskMenu.root_menu);
                UIManager.NavigationCanceled = true;
            }
            else if (key.ToLower() == "back") // navigate back
            {
                UIManager.render_ui(UIManager.UIAction.MENU, UIManager.current_menu_item); // return to the menu back
                UIManager.NavigationCanceled = true;
            }
            else // it's key press
            {
                switch (key.ToLower())
                {
                    case "{capslock}": // capslock is handled in flash
                        developer_buffer += "c";
                        check_developer_buffer();
                        break;
                    case "{backspace}":
                        developer_buffer += "b";
                        check_developer_buffer();
                        SendKeys.SendWait("{BACKSPACE}"); // send the backspace
                        break;
                    case "{space}": // space need special handling
                        SendKeys.SendWait(" ");
                        break;
                    default:
                        developer_buffer = "";
                        SendKeys.SendWait(key); // send recived key
                        break;
                }
            }
        }

        private static void flash_preload_continue() // fires when user clicks the continue button on preload movie
        {
            UIManager.render_ui(UIManager.UIAction.MENU, UIManager.current_menu_item); // render the current menu now after preload movie is shown
        }

        private static void flash_button_click(string args)
        {
            try
            {
                if (args == "menu_back") // back button
                {
                    UIManager.render_ui(UIManager.UIAction.MENU, UIManager.current_menu_item.parent); // render the parent menu
                }
                else // render a child menu, arg contains the name of the child to render
                {
                    item child;
                    child = KioskMenu.find_child(UIManager.current_menu_item, args);
                    if (child != null) // if found the given child
                    {
                        // check the found sub-menu and take actions using the priorities;
                        // 1- if it has a defined URL, then render the URL
                        // 2- if it has a preload_movie defined then first render the movie
                        // 3- render it as a menu

                        if (child.url.Length > 0)
                            UIManager.render_ui(UIManager.UIAction.WEBPAGE, child); // if it has a defined URL, then render the URL
                        else if (child.preload_movie.Length > 0)
                            UIManager.render_ui(UIManager.UIAction.PRELOAD_MOVIE, child); // if it has a preload_movie defined then first render the movie
                        else
                            UIManager.render_ui(UIManager.UIAction.MENU, child);
                    }
                    else
                    {
                        ExceptionHandler.handle("İstenen alt menu bulunamadı: " + args);
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }


        private static void check_developer_buffer()
        {
            try
            {
                if (developer_buffer == "ccccbbbbccccbbbb") // developer mode on
                {
                    //frmDevPassword frm = new frmDevPassword();
                    //Program.PasswordForm = frm;
                    //frm.ShowDialog();
                    Kiosk.developer_mode(); // go developer mode
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }
    }
}
