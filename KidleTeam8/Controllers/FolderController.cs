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
        public static bool AddFolder(ClassFolder folder)
        {  
            using (var _context = new DBFolderContext())
            {
                foreach (var file in folder.listfile)
                {
                    var dbFile = _context.tbFiles.Single(x => x.namefile == file.namefile);
                    if (dbFile.folder is null)
                    {
                        dbFile.folder = new List<ClassFolder>();
                    }
                    dbFile.folder.Add(folder);
                }
                folder.listfile.Clear();
                _context.tbFolders.AddOrUpdate(folder);
                _context.SaveChanges();
                return true;
            }
        }
        //Lấy listfile trong database dựa vào tên folder
        public static List<ClassFile> getListFile(string namefolder)
        {
            using (var _context = new DBFolderContext())
            {
                var dbListFile = (from lf in _context.tbFolders
                               where lf.namefolder == namefolder
                               select lf.listfile).Single().ToList();
                if (dbListFile.Count() >= 0)
                {
                    return dbListFile;
                }
                else
                    return null;
            }
        }
        //Kiểm tra xem có file nào được lưu trong folder hay không
        public static bool Containfif(ClassFile file)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFolder = (from f in _context.tbFolders.Include("listfile").AsEnumerable()
                                select new
                                {
                                    foldername = f.namefolder,
                                    listfiles = f.listfile
                                })
                                .Select(x => new ClassFolder
                                {
                                    namefolder = x.foldername,
                                    listfile = x.listfiles
                                }).ToList();
                int i = 0;
                foreach (ClassFolder folder in dbFolder)
                {
                    i = i + folder.listfile.Where(x => x.ID == file.ID).Count();
                }
                if(i>=1)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
        }
        //Thay đổi tên của folder trong database
        public static bool UpdateFolder(ClassFolder folder)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFolder = (from f in _context.tbFolders
                                where f.namefolder == folder.namefolder
                                select f).SingleOrDefault();
                foreach (var file in folder.listfile)
                {
                    var dbFile = (from x in _context.tbFiles
                                  where x.ID == file.ID
                                  select x).SingleOrDefault();
                    dbFile.folder.Add(dbFolder);
                }
                folder.listfile.Clear();
                _context.tbFolders.AddOrUpdate(dbFolder);
                _context.SaveChanges();
                return true;
            }
        }
        //Xóa 1 folder trong database
        public static bool DeleteFolder(ClassFolder folder)
        {
            using (var _context = new DBFolderContext())
            {
                var dbfolder = (from u in _context.tbFolders
                                where u.namefolder == folder.namefolder
                                select u).SingleOrDefault();
                foreach (var file in dbfolder.listfile)
                {
                    foreach (var f in file.folder)
                    {
                        if (f.namefolder == folder.namefolder)
                        {
                            file.folder.Remove(f);
                            break;
                        }
                    }
                }
                _context.tbFolders.Remove(dbfolder);
                _context.SaveChanges();
                return true;
            }
        }
        //Xóa file trong folder trên database
        public static bool DeleteFile(string namefolder, int ID)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFolder = (from f in _context.tbFolders
                                where f.namefolder == namefolder
                                select f).Single();
                dbFolder.listfile = (from lf in _context.tbFolders
                                     where lf.namefolder == namefolder
                                     select lf.listfile).Single().ToList();
                var file = (from f in _context.tbFiles
                            where f.ID == ID
                            select f).Single();
                file.folder = (from f in _context.tbFiles
                                 where f.ID == ID
                                 select f.folder).Single().ToList();
                file.folder.Remove(dbFolder);
                dbFolder.listfile.Clear();
                _context.tbFolders.AddOrUpdate(dbFolder);
                _context.SaveChanges();
                return true;
            }
        }
        //Lấy folder với tên folder
        public static ClassFolder getFolder(string namefolder)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFolder = (from f in _context.tbFolders
                                where f.namefolder == namefolder
                                select f).Single();
                dbFolder.listfile = (from lf in _context.tbFolders
                                     where lf.namefolder == namefolder
                                     select lf.listfile).Single().ToList();
                if (dbFolder.listfile == null)
                {
                    return null;
                }
                else
                {
                    return dbFolder;
                }
            }
        }
        //Thêm file vào folder
        public static bool AddFile(ClassFolder folder, ClassFile file)
        {
            using (var _context = new DBFolderContext())
            {
                folder.listfile.Add(file);
                _context.tbFolders.AddOrUpdate(folder);
                _context.SaveChanges();
                return true;
            }
        }
        //Lấy tất cả folder từ database
        public static List<ClassFolder> GetAllFolder()
        {
            using (var _context = new DBFolderContext())
            {
                var dbFolder = (from f in _context.tbFolders.Include("listfile").AsEnumerable()
                              select new
                              {
                                  foldername = f.namefolder,
                                  listfiles = f.listfile
                              })
                              .Select(x => new ClassFolder
                              {
                                  namefolder = x.foldername,
                                  listfile = x.listfiles
                              });
                return dbFolder.ToList();
            }
        }
    }
}
