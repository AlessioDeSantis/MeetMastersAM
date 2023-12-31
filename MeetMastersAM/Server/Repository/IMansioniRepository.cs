﻿using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public interface IMansioniRepository : IRepositoryBase<Mansioni>
    {
        public Task<IEnumerable<Mansioni>> GetDetailsMansioniAsync();
    }
}
