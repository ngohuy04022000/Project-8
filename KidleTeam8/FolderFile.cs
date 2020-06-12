using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleTeam8
{
    [Table("Folder")]
    public class FolderFile
    {
        [Key]
        public string namefolder { get; set; }
        public List<string> filename { get; set; }
    }
}
