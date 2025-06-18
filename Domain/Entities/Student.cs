using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstract;

namespace Domain.Entities;

[Table("students")]
public class Student : DbEntity
{
    // [Key]
    // public Guid Id { get; set; } = Guid.NewGuid();
    //
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    
    public Group Group { get; set; }
}