using Microsoft.AspNetCore.Mvc;
using ProdutoApi.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        [HttpGet("GetProdutos", Name = "GetProdutos")]
        public async Task<IActionResult> GetAllAsync()
        {
            var listar = ListarProdutos();
            return Json(listar);
        }

        [HttpGet("GetProduto", Name = "GetProdutos")]
        [HttpGet("GetProdutoByid/{id}", Name = "GetProdutoById/(id)")]

        public async Task<IActionResult> GetById(long id)
        {
            var produto = ListarProdutos().FirstOrDefault(c => c.Id == id);
            return Json(produto);
        }



        private List<ProdutoEntidade> ListarProdutos()
        {
            List<ProdutoEntidade> listMock = new List<ProdutoEntidade>();
            for (int i = 0; i < 6; i++)
            {
                ProdutoEntidade objProduto = new ProdutoEntidade();
                objProduto.Id = i;
                objProduto.Nome = "Produto " + i;
                listMock.Add(objProduto);
            }
            return listMock;
        }



    }
}