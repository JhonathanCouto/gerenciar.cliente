using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.Admin.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Detalhe()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
        
        public IActionResult Atualizar()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
