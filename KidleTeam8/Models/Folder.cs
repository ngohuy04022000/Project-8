using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleTeam8.Models
{
    [Table("Folder")]
    public class Folder
    {
        [Key]
        public string namefolder { get; set; }
        public virtual ICollection<Files> filename { get; set; }
        public override string ToString()
        {
            return this.namefolder;
        }
    }
}
