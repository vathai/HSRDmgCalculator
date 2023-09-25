﻿using DamageCalcLibrary.Models;

namespace DamageCalcLibrary.Data
{
    public interface IAttackerData
    {
        Task DeleteAttacker(int id);
        Task<Attacker?> GetAttacker(int id);
        Task<IEnumerable<Attacker>> GetAttackers();
        Task InsertAttacker(Attacker attacker);
        Task UpdateAttacker(Attacker attacker);
    }
}