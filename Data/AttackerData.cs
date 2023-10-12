using DamageCalcLibrary.DbAccess;
using DamageCalcLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalcLibrary.Data;
public class AttackerData : IAttackerData
{
    private readonly ISqlDataAccess _db;

    public AttackerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<Attacker>> GetAttackers() =>
        _db.LoadData<Attacker, dynamic>("dbo.spAttacker_GetAll", new { });

    public async Task<Attacker?> GetAttacker(int id)
    {
        var results = await _db.LoadData<Attacker, dynamic>(
            storedProcedure: "dbo.spAttacker_Get", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertAttacker(Attacker attacker) =>
        _db.SaveData(storedProcedure: "dbo.spAttacker_Insert",
            new
            {
                attacker.CharName,
                attacker.CharLevel,
                attacker.Attack,
                attacker.Crit,
                attacker.CritDamage,
                attacker.BreakEffect,
                attacker.DamageBoost,
                attacker.ElementalDmgBoost
            });

    public Task UpdateAttacker(Attacker attacker) =>
        _db.SaveData(storedProcedure: "dbo.spAttacker_Update", attacker);

    public Task DeleteAttacker(int id) =>
        _db.SaveData(storedProcedure: "dbo.spAttacker_Delete", new { Id = id });
}
