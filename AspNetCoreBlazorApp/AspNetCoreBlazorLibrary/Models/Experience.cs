using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspNetCoreBlazorLibrary.Models;

public class Experience
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    [DisplayName("Company Name")]
    public string Company{ get; set; }
    [Required]
    [StringLength(50)]
    [DisplayName("Ship Name")]
    public string ShipName { get; set; }
    public string ShipType { get; set; }
    public string Engine { get; set; }
    public string ShipDWT { get; set; }
    [DisplayName("Start Date")]
    [DataType(DataType.Date)]
    public DateTime FromDate { get; set; }
    [DisplayName("End Date")]
    [DataType(DataType.Date)]
    public DateTime ToDate { get; set; }

}
