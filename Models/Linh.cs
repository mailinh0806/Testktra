using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TestKT.Models
{
        public class Linh
    {
        [Key]
        public string IDten { get; set;}
        public string Ten { get; set;}
        public string Tinhcach { get; set;}
        public string Ma { get; set; }
        
        [ForeignKey("Ma")]
        public People? People {get; set;} 
    }
}
//test tạo