using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace DevHobby.Models.Entities;

public class Order
{
    [BindNever]
    public int OrderId { get; set; }

    [Required(ErrorMessage = "Proszę podaj swoje imię")]
    [Display(Name = "Imię")]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Proszę podać swoje nazwisko")]
    [Display(Name = "Nazwisko")]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Proszę podać swój adres")]
    [StringLength(100)]
    [Display(Name = "Address")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Proszę podać miasto")]
    [StringLength(50)]
    [Display(Name = "Miasto")]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "Proszę podać kraj")]
    [StringLength(50)]
    [Display(Name = "Kraj")]
    public string Country { get; set; } = string.Empty;

    [Required(ErrorMessage = "Proszę podać numer telefonu")]
    [StringLength(25)]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Numer telefonu")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Proszę podać email")]
    [StringLength(50)]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
         ErrorMessage = "Adres e-mail został wprowadzony w nieprawidłowym formacie")]
    public string Email { get; set; } = string.Empty;

    [BindNever]
    public decimal OrderTotal { get; set; }

    [BindNever]
    public DateTime OrderPlaced { get; set; }
    public List<OrderDetail>? OrderDetails { get; set; }

}
