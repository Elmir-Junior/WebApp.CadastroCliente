using Microsoft.AspNetCore.Mvc;
using WebApp.CadastroCliente.Dominio.Models;
using WebApp.CadastroCliente.Aplication.Services.Services;

namespace WebApp.CadastroCliente.Aplication.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ServiceClienteApi _serviceCliente;

        public ClienteController(ServiceClienteApi serviceCliente)
        {
            _serviceCliente = serviceCliente;
        }

        public ActionResult Index()
        {
            return View(_serviceCliente.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(_serviceCliente.GetById(id));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                _serviceCliente.Add(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(_serviceCliente.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                _serviceCliente.Update(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_serviceCliente.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                _serviceCliente.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
