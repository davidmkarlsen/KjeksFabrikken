using System.ComponentModel.DataAnnotations;
using KjeksFabrikken.Models;

namespace KjeksFabrikken.ViewModels;

public class CookieCategory
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public int CookieId { get; set; }

    [Required]
    public int CategoryId { get; set; }
    
    public virtual Cookie Cookie { get; set; }
    
    public virtual Category Category { get; set; }
}