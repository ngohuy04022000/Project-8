using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace KindleTeam8.Models
{
    [Table("Folder")]
    public class ClassFolder
    {
        [Key]
        public string namefolder { get; set; }
        public ICollection<ClassFile> listfile { get; set; }
        public ClassFolder()
        {
            listfile = new HashSet<ClassFile>();
        }
        public override string ToString()
        {
            return this.namefolder;
        }
    }
}
