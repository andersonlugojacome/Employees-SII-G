using Employees_SII_G.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

namespace Employees_SII_G.DataAccess;

public class EmployeeService
{
    private readonly HttpClient _httpClient;

    public EmployeeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Employees>> GetEmployeesAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("https://dummy.restapiexample.com/api/v1/employees");

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.Conflict)
                {
                    throw new InvalidOperationException("Conflict: The request could not be completed due to a conflict with the current state of the target resource.");
                }

                response.EnsureSuccessStatusCode();
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<List<Employees>>>(jsonString);

            return apiResponse?.Data ?? new List<Employees>();
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            throw new InvalidOperationException("Error connecting to the API: " + ex.Message, ex);
        }
    }
    public async Task<Employees> GetEmployeeByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"https://dummy.restapiexample.com/api/v1/employees/{id}");
        response.EnsureSuccessStatusCode();

        var jsonString = await response.Content.ReadAsStringAsync();
        var apiResponse = JsonSerializer.Deserialize<ApiResponse<Employees>>(jsonString);

        return apiResponse?.Data ?? new Employees();
    }
}