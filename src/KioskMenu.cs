using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace kiosksharp
{
    public static class KioskMenu
    {
        public static item root_menu = new item("root"); // the root menu

        //public static item get_item(string key) // find the given named item from the list
        //{
        //    return walk_childs(root_menu, key);
        //}

        public static item find_child(item parent, string child_name)
        {
            foreach (item i in parent.childs)
            {
                if (i.name.ToLower() == child_name.ToLower())
                    return i;
            }
            return null;
        }

        private static item walk_childs(item root, string key) // walk through all items and find the given key in the name
        {
            foreach (item t in root.childs)
            {
                if (key.ToLower() == t.name) // found the target
                    return t;
                if (t.childs.Count > 0) // if we've childs, walk them too
                {
                    item n = walk_childs(t, key);
                    if (n != null) return n;
                }
            }
            return null; // if not found
        }

        public static void Dispose() // dispose & free the resources
        {
            foreach (item i in root_menu.childs) // dispose the childs
            {
                i.Dispose();
            }
            GC.Collect(); // force a garbage collection
        }
    }

    public class item // menu-item
    {
        public string name; // <label>
        public string url; // <url> - the web page to open
        public string preload_movie; // <preload_movie> - the preload movie to render
        public ArrayList childs; // child menus
        public item parent; // the parent


        // constructors
        public item(string _name)
        {
            name = _name;
            url = preload_movie = "";
            childs = new ArrayList();
        }

        public item()
        {
            name = url = preload_movie = "";
            childs = new ArrayList();
        }

        internal void Dispose()
        {
            childs.Clear();
            childs = null;
        }
    }
}
