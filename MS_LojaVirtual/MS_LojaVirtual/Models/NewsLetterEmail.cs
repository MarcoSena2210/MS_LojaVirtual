﻿using MS_LojaVirtual.Libraries.Lang;
using System.ComponentModel.DataAnnotations;

namespace MS_LojaVirtual.Models
{
     public class NewsLetterEmail
     {
          public int Id{ get; set; }
          [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
          [EmailAddress(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E004")]
          public string Email { get; set; }
     }
}
