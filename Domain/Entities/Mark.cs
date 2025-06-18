using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstract;

namespace Domain.Entities;

[Table("marks")]
public class Mark : DbEntity
{
    public int Value { get; set; }
    
    public Guid StudentId { get; set; }
    public Student Student { get; set; }
}