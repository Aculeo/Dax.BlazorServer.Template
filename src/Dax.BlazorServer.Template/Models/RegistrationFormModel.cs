using System.ComponentModel.DataAnnotations;

namespace Dax.BlazorServer.Template.Models;

public class RegistrationFormModel
{
    [Required(ErrorMessage = "Vorname ist erforderlich.")]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Nachname ist erforderlich.")]
    public string LastName { get; set; } = "";

    public void Clear()
    {
        FirstName = "";
        LastName = "";
    }
}