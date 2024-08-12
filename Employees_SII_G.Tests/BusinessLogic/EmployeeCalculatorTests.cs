using Employees_SII_G.BusinessLogic;
using Xunit;
namespace Employees_SII_G.Tests.BusinessLogic;


public class EmployeeCalculatorTests
{
    [Fact]
    public void CalculateAnnualSalary_ShouldReturnCorrectValue()
    {
        // Arrange
        var calculator = new EmployeeCalculator();
        decimal monthlySalary = 5000m;

        // Act
        decimal annualSalary = calculator.CalculateAnnualSalary(monthlySalary);

        // Assert
        Assert.Equal(60000m, annualSalary);
    }
}