using Microsoft.AspNetCore.Mvc;
using MS_LojaVirtual.Models;

namespace MS_LojaVirtual.Controllers
{
     public class ProdutoController : Controller
      {
          public ActionResult Visualizar() 
          {
               Produto produto = GetProduto();
               
               
               return View(produto);
        //       return  new ContentResult() { Content = "<h3>Produto ==> visualizar </h3>", ContentType = "text/html" };
          }

          private Produto GetProduto()
          {
               return new Produto()
               {
                    Id = 1,
                    Nome = "Bruna",
                    Descricao = "Pulseira de primeira ",
                    Valor = 10.00M
               };
            
          }
     }
}
