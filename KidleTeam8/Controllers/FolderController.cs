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
        //Thêm 1 folder vào database
        public static bool AddFolder(Folder folder)
        {
            try
            {
                using (var _context = new DBFolderContext())
                {
                    _context.tbFolders.Add(folder);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        //Hiển thị list folder khi mở lại form
        public static List<Folder> getListFolder()
        {
            using (var _context = new DBFolderContext())
            {
                var folder = (from f in _context.tbFolders
                              select f).ToList();
                return folder;

            }
        }
        //Lấy folder trong database dựa vào tên
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
        //Thay đổi tên của folder trong database
        public static bool UpdateFolder(Folder folder)
        {
            using (var _context = new DBFolderContext())
            {
                _context.tbFolders.AddOrUpdate(folder);
                _context.SaveChanges();
                return true;
            }
        }
        //Xóa 1 folder trong database
        public static bool DeleteFolder(Folder folder)
        {
            using (var _context = new DBFolderContext())
            {
                var dbfolder = (from u in _context.tbFolders
                                where u.namefolder == folder.namefolder
                                select u).SingleOrDefault();
                foreach (var file in dbfolder.filename)
                {
                    foreach (var u in file.folder)
                    {
                        if (u.namefolder == folder.namefolder)
                        {
                            file.folder.Remove(u);
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
