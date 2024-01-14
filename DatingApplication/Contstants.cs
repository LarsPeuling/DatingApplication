using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication
{
    public static class Contstants
    {
        private const string DBFileName = "Binder.db";
        public const SQLiteOpenFlags flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
