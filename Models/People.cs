
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestKT.Models;
[Table("People")]
public class People
{
    [Key]
    public string Ma { get; set;}
    public string Ten { get; set;}
    public string DiaChi { get; set; }
}
