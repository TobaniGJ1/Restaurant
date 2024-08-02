using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaunt.Web.Services.IServices;
using WebApplication1.Web.Data.Models.Empleado;

namespace Restaunt.Web.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoServices _empleadoServices;
        public EmpleadoController(IEmpleadoServices empleadoServices)
        {
            _empleadoServices = empleadoServices;
        }
        // GET: ClienteController
        public async Task<ActionResult> Index()
        {
            var empleadoGetList = await _empleadoServices.GetList();

            if (!empleadoGetList.success)
            {
                ViewBag.Message = empleadoGetList.message;
                return View();
            }

            return View(empleadoGetList.data);
        }
        // GET: CustomersController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var clienteGetResult = await _empleadoServices.GetById(id);

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
        public async Task<ActionResult> Create(EmpleadoSaveModel empleadoSave)
        {
            try
            {
                var saveResult = await _empleadoServices.Save(empleadoSave);

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
            var clienteResult = await _empleadoServices.GetById(id);

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
        public async Task<ActionResult> Edit(int id, EmpleadoUpdateModel empleadoUpdate)
        {
            try
            {

                var updateResult = await _empleadoServices.Update(empleadoUpdate);

                if (!updateResult.success)
                {
                    ViewBag.Message = updateResult.message;
                    return View(empleadoUpdate);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error inesperado: {ex.Message}";
                return View(empleadoUpdate);
            }
        }

    }
}
