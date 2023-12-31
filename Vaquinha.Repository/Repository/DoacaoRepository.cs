﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vaquinha.Domain.Configuration;
using Vaquinha.Domain.Entities;
using Vaquinha.Domain.Interfaces.Repository;
using Vaquinha.Repository.Context;

namespace Vaquinha.Repository.Repository
{
    public class DoacaoRepository : IDoacaoRepository
    {
        private readonly ILogger<DoacaoRepository> _logger;
        private readonly GloballAppConfig _globalSettings;
        private readonly VaquinhaOnlineDBContext _vaquinhaOnlineDBContext;

        public DoacaoRepository(GloballAppConfig globalSettings,
                                VaquinhaOnlineDBContext vaquinhaDbContext,
                                ILogger<DoacaoRepository> logger)
        {
            _globalSettings = globalSettings;
            _vaquinhaOnlineDBContext = vaquinhaDbContext;
            _logger = logger;
        }

        public async Task AdicionarAsync(Doacao model)
        {
            await _vaquinhaOnlineDBContext.Doacoes.AddAsync(model);
            await _vaquinhaOnlineDBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Doacao>> RecuperarDoadoesAsync(int pageIndex = 0)
        {
            return await _vaquinhaOnlineDBContext.Doacoes.Include("DadosPessoais").ToListAsync();
        }
    }
}