﻿using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface IComuniService : IServiceBase<Comuni>
    {
        public Task<IEnumerable<Comuni>> GetDetailsComuni();
    }
}
