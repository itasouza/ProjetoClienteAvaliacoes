using Generico.Business.Interfaces;
using Generico.Business.Models;
using Generico.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Data.Repository
{
    public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(MeuDbContext context) : base(context) { }

    }
}
