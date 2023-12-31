﻿using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public interface IBenefitRepository : IRepositoryBase<Benefits>
    {
        public Task<IEnumerable<Benefits>> GetDetailsBenefitAsync();
    }
}
