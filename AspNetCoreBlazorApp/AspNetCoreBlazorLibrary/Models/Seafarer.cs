using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreBlazorLibrary.Models;

public class Seafarer
{
    [Key]
    public int SeafarerId { get; set; }
    [Required(ErrorMessage ="Please enter name..")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Please enter name..")]
    public string LastName { get; set; }
    [NotMapped]
    [Display(Name = "Full Name")]
    public string FullName { get { return $"{FirstName} {LastName}"; } }
    [Required(ErrorMessage = "Please enter email..")]
    [EmailAddress(ErrorMessage = "Please enter a valid e-mail..")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Please select your rank..")]
    public string Rank { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public virtual ICollection<Experience> Experiences { get; set; }

}
