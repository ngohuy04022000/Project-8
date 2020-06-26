using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleTeam8.Models
{
    [Table("Files")]
    public class ClassFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }//Liên kết bằng ID
        public string namefile { get; set; }
        public string path { get; set; }
        public string size { get; set; }
        public string note { get; set; }
        public int linkedfilein { get; set; }
        public int linkedfileout { get; set; }
        public virtual ICollection<ClassFolder> folder { get; set; }
        public ClassFile()
        {
            folder = new HashSet<ClassFolder>();
            //linkedfile = new ClassFile();
        }
        public override string ToString()
        {
            return this.namefile;
        }
    }
}
