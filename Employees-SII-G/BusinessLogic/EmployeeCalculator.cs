namespace Employees_SII_G.BusinessLogic;

public class EmployeeCalculator
{
    public decimal CalculateAnnualSalary(decimal monthlySalary)
    {
        return monthlySalary * 12;
    }
}