using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace kiosksharp
{
    public static class XMLConfig
    {
        public static void init()
        {
            read_xml(); // start reading the xml
        }

        public static void read_xml()
        {
            try
            {
                XmlDocument xml_doc = new XmlDocument();
                xml_doc.Load(Properties.Settings.Default["XmlConfig"].ToString()); // load xml configuration 
                KioskMenu.root_menu.parent = KioskMenu.root_menu; // root menu's parent is itself
                get_items(xml_doc.SelectNodes("config"), KioskMenu.root_menu); // read configuration
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }

        private static void get_items(XmlNodeList _node, item parent)
        {
            try
            {
                XmlNodeList items = _node.Item(0).SelectNodes("item"); // read the <item>s
                foreach (XmlNode node in items) // loop through each item
                {
                    item t = new item(); // new menu item
                    t.parent = parent;  // set parent
                    XmlNodeList childs = node.ChildNodes; // find child nodes
                    foreach (XmlNode child in childs) // for each child node
                    {
                        switch (child.Name) 
                        {
                            case "label": //<label>
                                t.name = child.InnerText;
                                break;
                            case "url": //<url>
                                t.url = child.InnerText;
                                break;
                            case "childs": //<childs>
                                get_items(node.SelectNodes("childs"), t); // get the child menus
                                break;
                            case "preload_movie": //<preload_movie>>
                                t.preload_movie = child.InnerText;
                                break;
                        }
                    }
                    parent.childs.Add(t); // add to parents childs
                    t = null; 
                }
            }
            catch (Exception e)
            {
                ExceptionHandler.handle(e);
            }
        }


    }
}
