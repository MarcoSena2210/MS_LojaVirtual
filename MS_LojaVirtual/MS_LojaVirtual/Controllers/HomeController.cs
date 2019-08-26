﻿using Microsoft.AspNetCore.Mvc;
using MS_LojaVirtual.Libraries.Email;
using MS_LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
               try
               {
                    Contato contato = new Contato();
                    contato.Nome = HttpContext.Request.Form["nome"];
                    contato.Email = HttpContext.Request.Form["email"];
                    contato.Texto = HttpContext.Request.Form["texto"];

                    var listaMensagens = new List<ValidationResult>();
                    var contexto = new ValidationContext(contato);
                    bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                    if (isValid)
                    {
                         ContatoEmail.EnviarContatoPorEmail(contato);

                         ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                    }
                    else
                    {
                         StringBuilder sb = new StringBuilder();
                         foreach (var texto in listaMensagens)
                         {
                              sb.Append(texto.ErrorMessage + "<br />");
                         }
                         ViewData["MSG_E"] = sb.ToString();
                         ViewData["CONTATO"] = contato;
                    }
               }
               catch (Exception )
               {
                    ViewData["MSG_E"] = "Opps! Tivemos um erro, tente novamente mais tarde!";

                    //TODO - Implementar Log
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