using Generico.Business.Interfaces;
using Generico.Business.Models;
using Generico.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }

        public async Task<Produto> ObterProdutoEspecifico(int produtoId)
        {
            return await Db.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == produtoId);
        }


    }
}
