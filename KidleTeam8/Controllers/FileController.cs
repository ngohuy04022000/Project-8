using KindleTeam8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
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
        //Cập nhật file
        public static bool UpdateFile(ClassFile filename)
        {
            using (var _context = new DBFolderContext())
            {
                //if (filename.linkedfile != null)
                //{
                    //var dbFile = (from f in _context.tbFiles
                    //              where f.ID == filename.ID
                    //              select f).SingleOrDefault();
                    //dbFile.linkedfile = filename.linkedfile;
                    //_context.tbFiles.AddOrUpdate(dbFile);
                    //_context.tbFiles.SqlQuery("Select * from Files where ID=@id", new  SqlParameter("@id",filename.ID)).FirstOrDefault();
                    //_context.Database.ExecuteSqlCommand("Update Files set linkedfile =@iid where ID=@id",
                    //    new SqlParameter("@id", filename.ID), new SqlParameter("@iid", filename.linkedfile));
                    //_context.SaveChanges();
                    //return true;
                //}
                //filename.folder.Clear();
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
        //Xóa file ra khỏi database
        public static bool DeleteFile(int ID)
        {
            using (var _context = new DBFolderContext())
            {
                var dbFile = (from f in _context.tbFiles
                                where f.ID == ID
                                select f).SingleOrDefault();
                foreach (var fol in dbFile.folder)
                {
                    foreach (var file in fol.listfile)
                    {
                        if (file.ID == ID)
                        {
                            fol.listfile.Remove(file);
                            break;
                        }
                    }
                }
                _context.tbFiles.Remove(dbFile);
                _context.SaveChanges();
                return true;
            }
        }
        //Lấy file từ ID của nó
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
	//Lấy file dựa theo tên của nó
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
                                size=f.size,
                                note=f.note,
                                linkedfilein = f.linkedfilein,
                                linkedfileout = f.linkedfileout
                            })
                              .Select(x => new ClassFile
                               {
                                   ID = x.ID,
                                   namefile = x.filename,
                                   path = x.path,
                                   size = x.size,
                                   note=x.note,
                                   linkedfilein = x.linkedfilein,
                                   linkedfileout =x.linkedfileout
                               }).ToList();
                return file;
            }
        }
    }
}
