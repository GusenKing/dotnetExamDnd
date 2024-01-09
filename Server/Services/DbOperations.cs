using Models;
using Server.DB;

namespace Server.Services;

public class DbOperations : IDbOperations
{
    private readonly AppDbContext _dbContext;
    private readonly Random _random = new Random();

    public DbOperations(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Monster GetRandomMonster()
    {
        var dbSet = _dbContext.Monsters;
        var randomId = _random.Next(1, dbSet.ToList().Count + 1);
        return dbSet
            .Where(m => m.MonsterId == randomId)
            .FirstOrDefault();
    }
}