using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employees_SII_G.Models;
using Employees_SII_G.BusinessLogic;
using Employees_SII_G.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Employees_SII_G.Controllers;

public class HomeController : Controller
{
    private readonly EmployeeService _employeeService;
    private readonly EmployeeCalculator _calculator;

    public HomeController(EmployeeService employeeService, EmployeeCalculator calculator)
    {
        _employeeService = employeeService;
        _calculator = calculator;
    }
    public async Task<IActionResult> Index(string employeeId)
    {
        List<Employees> employees = new List<Employees>();
        string errorMessage = null;

        try
        {
            if (string.IsNullOrEmpty(employeeId))
            {
                employees = await _employeeService.GetEmployeesAsync();
            }
            else
            {
                var employee = await _employeeService.GetEmployeeByIdAsync(int.Parse(employeeId));

                if (employee == null)
                {
                    errorMessage = "Employee not found."; // Mensaje si el empleado no se encuentra
                }
                else
                {
                    employees = new List<Employees> { employee };
                }
            }

            foreach (var employee in employees)
            {
                employee.AnnualSalary = _calculator.CalculateAnnualSalary(employee.Salary);
            }
        }
        catch (InvalidOperationException ex)
        {
            errorMessage = ex.Message; // Captura el mensaje de error para mostrar en la vista
        }

        ViewData["EmployeeId"] = employeeId;
        ViewData["ErrorMessage"] = errorMessage; // Pasar el mensaje de error a la vista

        return View(employees);
    }

}