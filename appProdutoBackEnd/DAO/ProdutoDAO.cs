using appProdutoBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appProdutoBackEnd.DAO
{
    public class ProdutoDAO
    {
        private readonly AppDbContext _context;

        public ProdutoDAO(AppDbContext context)
        {
            this._context = context;
        }

        public Task<List<Produto>> ObterTodos()
        {
            return _context.Produto.ToListAsync();
        }

        public async Task<Produto> ObterProdutoPorId(Int64 id)
        {
            return await _context.Produto.FindAsync(id);
        }

        public async void Alterar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
