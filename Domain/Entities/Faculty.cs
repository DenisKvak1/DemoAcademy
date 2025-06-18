using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstract;

namespace Domain.Entities;

[Table("faculties")]
public class Faculty : DbEntity
{
    public required string Name { get; set; }

    public List<Group> Groups { get; set; }
}