using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminCustomer : Controller
    {
        private readonly ICustomerService _customerService;

        public AdminCustomer(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult CustomerList()
        {
           
            var jsonKullanicilar = JsonConvert.SerializeObject(_customerService.TGetList());
            return Json(jsonKullanicilar);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TInsert(customer);
            var values = JsonConvert.SerializeObject(customer);
            return Json(values);
        }


        public IActionResult GetByID(int CustomerID)
        {
            var values = _customerService.TGetById(CustomerID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

    }
}
