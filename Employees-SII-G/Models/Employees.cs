using System.Text.Json.Serialization;

namespace Employees_SII_G.Models
{
    public class Employees
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("employee_name")]
        public string Name { get; set; }

        [JsonPropertyName("employee_salary")]
        public decimal Salary { get; set; }

        [JsonPropertyName("employee_age")]
        public int Age { get; set; }

        [JsonPropertyName("profile_image")]
        public string ProfileImage { get; set; }

        public decimal AnnualSalary { get; set; }
    }
}