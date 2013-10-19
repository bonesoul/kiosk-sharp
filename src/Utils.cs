using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace kiosksharp
{
    public static class Utils
    {
        public enum movie // movie type
        {
            loading,
            menu,
            keyboard,
            intro
        }

        public static string get_movie_path(movie mov) // get given movies type
        {
            string path = "";
            switch (mov )
            {
                case movie.loading:
                    path = get_movies_path() + Properties.Settings.Default["swf_loading"];
                    break;
                case movie.menu:
                    path = get_movies_path() + Properties.Settings.Default["swf_menu"];
                    break;
                case movie.keyboard:
                    path = get_movies_path() + Properties.Settings.Default["swf_keyboard"];
                    break;
                case movie.intro:
                    path = get_movies_path() + Properties.Settings.Default["swf_intro"];
                    break;
            }

            if (!File.Exists(path))
            {
                ExceptionHandler.handle("Gerekli dosya bulunamadı: " + path);
            }

            return path;
        }

        public static string get_movie_path(string movie) // string based version working with preload movies
        {
            string path = "";
            path = get_movies_path() + movie;              

            if(!File.Exists(path))
            {
                ExceptionHandler.handle("Gerekli dosya bulunamadı: " + path);
            }

            return path;
        }

        public static string get_movies_path() // get base movies path
        {
            String path="";
            try
            {
                path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Resources\";
                if (path.StartsWith(@"file:\"))
                    path = path.Substring(6);
            }
            catch(Exception e)
            {
                ExceptionHandler.handle(e);
            }
            
            return path;
        }
    }
}
