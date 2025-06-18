using System.ComponentModel.DataAnnotations;

namespace Domain.Abstract;

public interface IDbEntity<Key> where Key : IComparable
{
    [Key] public Key Id { get; set; }
}