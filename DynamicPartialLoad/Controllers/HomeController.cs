using DynamicPartialLoad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPartialLoad.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MyModel m = new MyModel();
            m.Header = string.Format("Parte de Cabecera Actualizada:{0}", DateTime.Now);
            m.Footer = string.Format("Parte de Pie de Página Actualizada:{0}", DateTime.Now);

            m.MainContent = new PageContent();
            m.MainContent.Title = "Página de Inicio";
            m.MainContent.Description = "Esta es la descripción de la página de Inicio:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
            return View(m);
        }

        public ActionResult Info()
        {
            MyModel m = new MyModel();
            m.Header = string.Format("Parte de Cabecera Actualizada:{0}", DateTime.Now);
            m.Footer = string.Format("Parte de Pie de Página Actualizada:{0}", DateTime.Now);

            m.MainContent = new PageContent();
            m.MainContent.Title = "Página de Información";
            m.MainContent.Description = "Esta es la descripción de la página de Información:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
            return View(m);
        }

        public ActionResult Contact()
        {
            MyModel m = new MyModel();
            m.Header = string.Format("Parte de Cabecera Actualizada:{0}", DateTime.Now);
            m.Footer = string.Format("Parte de Pie de Página Actualizada:{0}", DateTime.Now);

            m.MainContent = new PageContent();
            m.MainContent.Title = "Página de Contacto";
            m.MainContent.Description = "Esta es la descripción de la página de Contacto:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";

            return View(m);
        }
    }
}