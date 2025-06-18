using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstract;

namespace Domain.Entities;

[Table("groups")]
public class Group : DbEntity
{
    public required string Name { get; set; }
    
    public List<Student> Students { get; set; }
    public Faculty Faculty { get; set; }
    public Guid TeacherId { get; set; }
    public required Teacher Teacher { get; set; }
}