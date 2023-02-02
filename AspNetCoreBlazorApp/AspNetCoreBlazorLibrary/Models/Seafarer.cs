using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreBlazorLibrary.Models;

public class Seafarer
{
    [Key]
    public int SeafarerId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [NotMapped]
    [Display(Name = "Full Name")]
    public string FullName { get { return $"{FirstName} {LastName}"; } }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public string Rank { get; set; }
    public DateTime CreatedDate { get; set; }
    public virtual ICollection<Experience> Experiences { get; set; }

}
