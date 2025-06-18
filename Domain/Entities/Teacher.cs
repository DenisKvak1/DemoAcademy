using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstract;

namespace Domain.Entities;

[Table("teachers")]
public class Teacher : DbEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public List<Group> Teachers { get; } = [];
}