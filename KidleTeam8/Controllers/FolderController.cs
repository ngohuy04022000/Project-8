using KindleTeam8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleTeam8.Controllers
{
    public class FolderController
    {
        public static bool AddFolder(Folder f)
        {
            try
            {
                using (var _context = new DBFolderContext())
                {
                    _context.tbFolders.Add(f);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        //hiển thị list folder khi mở lại form
        public static List<Folder> getListFolder()
        {
            using (var _context = new DBFolderContext())
            {
                var folder = (from f in _context.tbFolders
                              select f).ToList();
                return folder;

            }
        }

        public static Folder getFolder(string namefolder)
        {
            using (var _context = new DBFolderContext())
            {
                var folder = (from f in _context.tbFolders
                              where f.namefolder == namefolder
                              select f).ToList();
                if (folder.Count == 1)
                {
                    return folder[0];
                }
                else
                    return null;

            }
        }

        public static bool UpdateFolder(Folder f)
        {
            using (var _context = new DBFolderContext())
            {
                _context.tbFolders.AddOrUpdate(f);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool DeleteFolder(Folder f)
        {
            using (var _context = new DBFolderContext())
            {
                var dbfolder = (from u in _context.tbFolders
                                where u.namefolder == f.namefolder
                                select u).SingleOrDefault();
                foreach (var t in dbfolder.filename)
                {
                    foreach (var u in t.folder)
                    {
                        if (u.namefolder == f.namefolder)
                        {
                            t.folder.Remove(u);
                            break;
                        }
                    }
                }
                _context.tbFolders.Remove(dbfolder);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
