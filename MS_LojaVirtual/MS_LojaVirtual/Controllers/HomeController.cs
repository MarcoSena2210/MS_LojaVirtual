﻿using Microsoft.AspNetCore.Mvc;

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