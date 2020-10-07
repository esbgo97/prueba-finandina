using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppSite.ClientServiceReference;
namespace AppSite.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientServiceClient clientService;
        public ClientController()
        {
            clientService = new ClientServiceClient();
        }
        // GET: Client
        public ActionResult Index()
        {
            var clients = clientService.GetAll();
            ViewBag.Clients = clients.ToList();
            return View();
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var newClient = new Client
                {
                    Names = collection.GetValue("Names").AttemptedValue,
                    LastNames= collection.GetValue("LastNames").AttemptedValue,
                    DocNumber = collection.GetValue("DocNumber").AttemptedValue,
                    Birth = DateTime.Parse(collection.GetValue("Birth").AttemptedValue),
                    IsActive = bool.Parse(collection.GetValue("IsActive").AttemptedValue)
                };
                clientService.Create(newClient);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(Client client)
        {
            ViewBag.Client = client;
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                var newClient = new Client
                {
                    Id = int.Parse(collection.GetValue("Id").AttemptedValue),
                    Names = collection.GetValue("Names").AttemptedValue,
                    LastNames = collection.GetValue("LastNames").AttemptedValue,
                    DocNumber = collection.GetValue("DocNumber").AttemptedValue,
                    Birth = DateTime.Parse(collection.GetValue("Birth").AttemptedValue),
                    IsActive = bool.Parse(collection.GetValue("IsActive").AttemptedValue)
                };
                clientService.Update(newClient);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
