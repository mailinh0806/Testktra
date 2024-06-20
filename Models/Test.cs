using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace TestKT.Models;

[Table("Test")]
public class Test
{
    [Key]
    public int Id { get; set;}
    public string Name { get; set;}

}