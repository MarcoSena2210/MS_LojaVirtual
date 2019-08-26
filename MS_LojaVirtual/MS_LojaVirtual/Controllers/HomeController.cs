﻿using Microsoft.AspNetCore.Mvc;
using MS_LojaVirtual.Libraries.Email;
using MS_LojaVirtual.Models;
using System;

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

               try {
                    Contato contato = new Contato();
                    contato.Nome = HttpContext.Request.Form["nome"];
                    contato.Email = HttpContext.Request.Form["email"];
                    contato.Texto = HttpContext.Request.Form["texto"];

                    ContatoEmail.EnviarContatoPorEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
               } catch (Exception) {

                    ViewData["MSG_E"] = "Atenção! Tivemos um erro, tente novamente mais tarde";

                    //TODO - Implementar log
               }
               return View("Contato");
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