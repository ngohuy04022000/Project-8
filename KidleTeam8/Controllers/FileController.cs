using KindleTeam8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleTeam8.Controllers
{
    public class FileController
    {
        public static int getIDfromDB()
        {
            using(var _context = new DBFolderContext())
            {
                var id = (from f in _context.tbFiles
                          select f.ID).ToList();
                if(id.Count<= 0) { return 1; }
                else 
                {
                    int i;
                    for(i=1;i<=id.Max();i++)
                    {
                        if(id.Contains(i) == false)
                        {
                            break;
                        }    
                    }
                    return i;
                }
            }    
        }
        //Thêm file vào database
        public static bool AddFile(ClassFile file)
        {
            try
            {
                using (var _context = new DBFolderContext())
                {
                    _context.tbFiles.Add(file);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateFile(ClassFile filename)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFile = (from f in _context.tbFiles
                              where f.ID == filename.ID
                              select f).SingleOrDefault();
                foreach (var fol in filename.folder)
                {
                    var dbFolder = (from u in _context.tbFolders
                                  where u.namefolder == fol.namefolder
                                  select u).SingleOrDefault();
                    dbFolder.listfile.Add(dbFile);
                }
                filename.folder.Clear();
                _context.tbFiles.AddOrUpdate(filename);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool getContain(ClassFile file)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFile = (from f in _context.tbFiles
                              where f.namefile == file.namefile
                              select f.size).FirstOrDefault();
                if(dbFile == file.size)
                {
                    return true;
                }    
                else
                { return false; }    
            }
        }
        public static bool DeleteFile(ClassFile file)
        {
            using (var _context = new DBFolderContext())
            {
                _context.tbFiles.Remove(file);
                _context.SaveChanges();
                return true;
            }
        }
        //Lấy file từ tên của nó
        public static ClassFile getFile(int ID)
        {
            using (var _context = new DBFolderContext())
            {
                var file = (from f in _context.tbFiles
                            where (f.ID == ID)
                            select f).ToList();
                if (file.Count == 1)
                    return file[0];
                else
                    return null;
            }
        }
        public static ClassFile getFile(string name)
        {
            using (var _context = new DBFolderContext())
            {
                var file = (from f in _context.tbFiles
                            where (f.namefile == name)
                            select f).ToList();
                if (file.Count == 1)
                    return file[0];
                else
                    return null;
            }
        }
        //Lấy toàn bộ file từ database hiện lên bảng
        public static List<ClassFile> getListFiles()
        {
            using (var _context = new DBFolderContext())
            {
                var file = (from f in _context.tbFiles.AsEnumerable()
                            select new
                            {
                                ID = f.ID,
                                filename = f.namefile,
                                path = f.path,
                                f.size
                            })
                              .Select(x => new ClassFile
                               {
                                   ID = x.ID,
                                   namefile = x.filename,
                                   path = x.path,
                                   size = x.size
                               }).ToList();
                return file;
            }
        }
    }
}
