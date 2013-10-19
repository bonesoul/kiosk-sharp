using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kiosksharp
{
    public static class SystemLock 
    {
        // user32.dll - hotkey definitions
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(IntPtr hwnd, int id);

        // WinLockDLL definitions
        [DllImport("WinLockDll", EntryPoint = "Desktop_Show_Hide")]
        private static extern int show_desktop(Boolean val);

        [DllImport("WinLockDll", EntryPoint = "StartButton_Show_Hide")]
        private static extern int show_startmenu(Boolean val);

        [DllImport("WinLockDll", EntryPoint = "Taskbar_Show_Hide")]
        private static extern int show_taskbar(Boolean val);

        [DllImport("WinLockDll", EntryPoint = "Clock_Show_Hide")]
        private static extern int show_clock(Boolean val);

        [DllImport("WinLockDll", EntryPoint = "Process_Desktop")]
        private static extern int fork_desktop_application(string name, string app_path);

        [DllImport("WinLockDll", EntryPoint = "TaskSwitching_Enable_Disable")]
        private static extern int enable_taskswitching(Boolean val);

        [DllImport("WinLockDll", EntryPoint = "TaskManager_Enable_Disable")]
        private static extern int enable_taskmanager(Boolean val);

        [DllImport("WinLockDll", EntryPoint = "CtrlAltDel_Enable_Disable")]
        private static extern int enable_ctrlaltdel(Boolean val);
     
        // Constants for modifier keys
        private const int MODIFIER_ALT = 1;
        private const int MODIFIER_CTRL = 2;
        private const int MODIFIER_SHIFT = 4;
        private const int MODIFIER_WIN = 8;

        private static short hotkey_index = 0;
        private static IntPtr handle;

        private static Boolean system_locked = false;

        //fork_desktop_application("calc", "calc.exe");

        public static void lock_system()
        {
            try
            {
                if ((bool)Properties.Settings.Default["system_lock"] == true) // if system lock is on
                {
                    if (!system_locked)
                    {
                        handle = Program.MainForm.Handle; // main form's handle

                        // Disable: Alt + F4, Alt + Tab
                        register_hotkey(Keys.F4, MODIFIER_ALT);
                        register_hotkey(Keys.Tab, MODIFIER_ALT);

                        // system locks
                        show_startmenu(false);
                        show_taskbar(false);
                        show_clock(false);
                        enable_taskswitching(false);
                        enable_taskmanager(false);
                        enable_ctrlaltdel(false);

                        system_locked = true;
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        public static void unlock_system()
        {
            try
            {
                if (system_locked)
                {
                    // re-enable the disabled hotkeys; alt+f4 and alt+tab
                    for (int i = 0; i < hotkey_index; i++)
                    {
                        UnregisterHotKey(handle, i);
                    }

                    // unlock the system
                    enable_ctrlaltdel(true);
                    enable_taskmanager(true);
                    enable_taskswitching(true);
                    show_clock(true);
                    show_taskbar(true);
                    show_startmenu(true);
                    system_locked = false;
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        private static void register_hotkey(Keys k, int modifier)
        {
            // registers a hotkey 
            hotkey_index++;

            if (RegisterHotKey(handle, hotkey_index, modifier, Convert.ToInt16(k)) == 0)
            {
                ExceptionHandler.handle("Hotkey kaydı yapılamadı: " + Marshal.GetLastWin32Error().ToString());
            }
        }
    }
}
