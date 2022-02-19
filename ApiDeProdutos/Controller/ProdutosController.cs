using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDeProdutos.Context;
using ApiDeProdutos.Data;

namespace ApiDeProdutos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoContext _context;

        public ProdutosController(ProdutoContext context)
        {
            _context = context;
        }

        // GET: api/Produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        // GET: api/Produtos/QuantidadeTotalDoEstoque
        [HttpGet("QuantidadeTotalDoEstoque")]

        public ActionResult<int> QuantidadeTotalDoEstoque()
        {

            var estoque = _context.Produtos.Sum(a => a.Quantidade);

            return estoque;
        }

        // GET: api/Produtos/TotalDeVendasDosProdutos
        [HttpGet("TotalDeVendasDosProdutos")]

        public ActionResult<int> TotalDeVendasDosProdutos()
        {

            var TotalDeVendas = _context.Produtos.Sum(a => a.TotalDeVendas);

            return TotalDeVendas;
        }

        // GET: api/Produtos/TotalDeComprasDosProdutos
        [HttpGet("TotalDeComprasDosProdutos")]

        public ActionResult<int> TotalDeComprasDosProdutos()
        {

            var TotalDeCompras = _context.Produtos.Sum(a => a.TotalDeCompras);

            return TotalDeCompras;
        }


        // 10 ultimos produtos adicionados
        // GET: api/Venda/DezUltimosProdutosAdicionados
        [HttpGet("DezUltimosProdutosAdicionados")]
        public async Task<ActionResult<IEnumerable<Produto>>> GetDezUltimosProdutosAdicionados()
        {

            return await _context.Produtos.OrderByDescending(c => c.Id).Take(10).ToListAsync();
        }

        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        // PUT: api/Produtos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Produtos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
