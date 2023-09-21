using DamageCalcLibrary.DbAccess;
using DamageCalcLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalcLibrary.Data;
public class AttackerData
{
    private readonly ISqlDataAccess _db;

    public AttackerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<Attacker>> GetAttackers() =>
        _db.LoadData<Attacker, dynamic>("dbo.spAttacker_GetAll", new { });
}
