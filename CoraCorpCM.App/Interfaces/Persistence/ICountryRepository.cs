﻿using CoraCorpCM.Domain.Entities;

namespace CoraCorpCM.App.Interfaces.Persistence
{
    public interface ICountryRepository : IReadOnlyRepository<Country,int>
    {
    }
}
