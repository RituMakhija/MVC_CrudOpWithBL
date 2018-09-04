using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;

namespace MVC_CrudOpUsingBL.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            List<Employee> employees = employeeBussinessLayer.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(FormCollection formCollection)
        {
            Employee employee = new Employee();
            employee.Name = formCollection["Name"];
            employee.Gender = formCollection["Gender"];
            employee.City = formCollection["City"];
            employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            employeeBussinessLayer.AddEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}