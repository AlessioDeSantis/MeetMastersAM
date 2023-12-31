﻿using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface IDipendentiService : IServiceBase<Dipendenti>
    {
        public Task<IEnumerable<Dipendenti>> GetDetailsDipendenti();
        public Task UpdateDipendentiManyToMany(Dipendenti entity);
    }
}
