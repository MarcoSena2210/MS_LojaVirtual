using Microsoft.AspNetCore.Mvc;
using MS_LojaVirtual.Libraries.Email;
using MS_LojaVirtual.Models;

namespace MS_LojaVirtual.Controllers
{
     public class HomeController : Controller
     {
          public IActionResult Index()
          {
               return View();
          }

          public IActionResult Contato()
          {
               return View();
          }

          public IActionResult ContatoAcao() {

               Contato contato = new Contato();
               contato.Nome = HttpContext.Request.Form["nome"];
               contato.Email = HttpContext.Request.Form["email"];
               contato.Texto = HttpContext.Request.Form["texto"];
               ContatoEmail.EnviarContatoPorEmail(contato);
               return new ContentResult() {        Content = string.Format( "Dados recebidos com sucesso! Nome: {0} <br/> E-mail: {1} <br/> Texto:{2} " , contato.Nome, contato.Email, contato.Texto), ContentType = "text/html"  };
          }

          public IActionResult Login()
          {
               return View();
          }

          public IActionResult CadastroCliente()
          {
               return View();
          }

          public IActionResult CarrinhoCompras()
          {
               return View();
          }
     }
}