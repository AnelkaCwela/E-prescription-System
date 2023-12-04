using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class DiagonosisModel
    {
        [Key]
        public int DiagonosisId { get; set; }
        public string? DiagonosisDescription { get; set; }
        

    }
}
