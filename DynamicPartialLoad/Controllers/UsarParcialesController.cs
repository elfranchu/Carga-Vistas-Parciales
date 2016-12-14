using DynamicPartialLoad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPartialLoad.Controllers
{
    public class UsarParcialesController : Controller
    {
        public ActionResult Index(string id)
        {
            MyModel m = new MyModel();
            m.Header = string.Format("Parte de Cabecera Actualizada:{0}", DateTime.Now);
            m.Footer = string.Format("Parte de Pie de Página Actualizada:{0}", DateTime.Now);

            if (id == "Info")
            {
                m.MainContent = new PageContent()
            {
                Title = "Página de Información",
                Description = "Esta es la descripción de la página de Información:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
            };
            }
            else if (id == "Contact")
            {
                m.MainContent = new PageContent()
            {
                Title = "Página de Contacto",
                Description = "Esta es la descripción de la página de Contacto:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
            };
            }
            else
            {
                //Sino devolver siempre la página de inicio
                m.MainContent = new PageContent()
             {
                 Title = "Página de Inicio",
                 Description = "Esta es la descripción de la página de Inicio:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
             };
            }

            return View(m);
        }
    }
}