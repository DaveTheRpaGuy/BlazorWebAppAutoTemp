using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class CalculatorModel
{
    [Required]
    public string Expression { get; set; }
}
