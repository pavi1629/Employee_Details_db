using Microsoft.AspNetCore.Mvc;
using Samplecore.Core.Iservices;
using Samplecore.Core.Model;

namespace Employee_Detail.Controllers
{
    public class employeeController : Controller
    {
        private readonly IEmployeeService _EmployeeServices;
        public employeeController(IEmployeeService services)
        {
            _EmployeeServices = services;
        }
        #region create operation

       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult result(employee value)
        {
            _EmployeeServices.CreateEmployeeEntry(value);
            return RedirectToAction("Read");
        }
        
        //To create View of this Action result
        public IActionResult employ()
        {
            return View();
        }
        #endregion

        #region Read operation

        
        public IActionResult Read()
        {

            var data = _EmployeeServices.Read();
            return View(data);

        }
        #endregion

        #region Update operation

        [HttpGet]
        public IActionResult Update(int Employee_Id)
        {
            var data = _EmployeeServices.Update(Employee_Id);
            // It will redirect to the Read method
            return View(data);
        }
        [HttpPost]
        public IActionResult Update( employee employ)
        {
            
            _EmployeeServices.Update(employ);
            return RedirectToAction("Read");
        }
        #endregion

        #region Delete operation

        
        public IActionResult Delete(int Employee_id)
        {
            _EmployeeServices.Delete(Employee_id);
            return RedirectToAction("Read");
        }
        #endregion
    }

}









