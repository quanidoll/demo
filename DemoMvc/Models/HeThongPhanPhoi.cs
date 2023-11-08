using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models
{
[Table("HeThongPhanPhois")]

public class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP { get; set; }
    public string TenHTPP { get; set; }
}
}
//Nguyen Minh Quan