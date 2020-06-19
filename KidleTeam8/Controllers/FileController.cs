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
        //Lấy file từ tên của nó
        public static ClassFile getFile(string filename)
        {
            using (var _context = new DBFolderContext())
            {
                var file = (from f in _context.tbFiles
                            where (f.namefile == filename)
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
                                filename = f.namefile,
                                f.path,
                                f.size
                            })
                              .Select(x => new ClassFile
                              {
                                  namefile = x.filename,
                                  path = x.path,
                                  size = x.size
                              }).ToList();
                return file;
            }
        }
    }
}
