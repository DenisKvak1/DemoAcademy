using Domain.Abstract;

namespace Abstract;

public interface IDbRepository<T, Key> 
    where Key:IComparable
    where T:class, IDbEntity<Key>
{
    IQueryable<T> AllItems { get; }
    Task<List<T>> ToListAsync();
    Task<bool> AddItemAsync(T item);
    Task<int> AddItemsAsync(IEnumerable<T> items);
    Task<T?> GetItemAsync(Key id);
    Task<bool> UpdateItemAsync(T item);
    Task<bool> DeleteItemAsync(Key id);
    Task<int> SaveChangesAsync();
}