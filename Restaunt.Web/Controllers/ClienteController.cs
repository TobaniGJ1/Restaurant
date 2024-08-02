using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaunt.Web.Services.IServices;
using WebApplication1.Web.Data.Models;

namespace Restaunt.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServices _clienteServices;
        public ClienteController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }
        // GET: ClienteController
        public async Task<ActionResult> Index()
        {
            var clienteGetList = await _clienteServices.GetList();

            if (!clienteGetList.success)
            {
                ViewBag.Message = clienteGetList.message;
                return View();
            }

            return View(clienteGetList.data);
        }
        // GET: CustomersController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var clienteGetResult = await _clienteServices.GetById(id);

            if (!clienteGetResult.success)
            {
                ViewBag.Message = clienteGetResult.message;
                return View();
            }

            return View(clienteGetResult.data);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClienteSaveModel customersSave)
        {
            try
            {
                var saveResult = await _clienteServices.Save(customersSave);

                if (!saveResult.success)
                {
                    ViewBag.Message = saveResult.message;
                    return View();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var clienteResult = await _clienteServices.GetById(id);

            if (!clienteResult.success)
            {
                ViewBag.Message = clienteResult.message;
                return View();
            }

            return View(clienteResult.data);
        }


        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ClienteUpdateModel clienteUpdate)
        {
            try
            {

                var updateResult = await _clienteServices.Update(clienteUpdate);

                if (!updateResult.success)
                {
                    ViewBag.Message = updateResult.message;
                    return View(clienteUpdate);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error inesperado: {ex.Message}";
                return View(clienteUpdate);
            }
        }

    }
}
