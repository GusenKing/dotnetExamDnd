using Models;

namespace Server.Services;

public interface IDbOperations
{
    Monster GetRandomMonster();
}