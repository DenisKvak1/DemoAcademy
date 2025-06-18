using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Abstract;

public class DbEntity : IDbEntity<Guid>
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
}