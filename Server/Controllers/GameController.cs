using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Services;

namespace Server.Controllers;

[ApiController]
[Route("controller")]
public class GameController
{
    // private IBattleLogic _battleLogic;
    //
    // public GameController(IBattleLogic battleLogic)
    // {
    //     _battleLogic = battleLogic;
    // }

    [HttpPost]
    [Route("processFight")]
    public JsonResult ProcessFight([FromBody] Player player,
        [FromServices] IBattleLogic battleLogic,
        [FromServices] IDbOperations dbOperations)
    {
        battleLogic.Player = player;
        battleLogic.Monster = dbOperations.GetRandomMonster();
        return new JsonResult(battleLogic.GetFightResult());
    }
} 