using System.ComponentModel.DataAnnotations;
namespace MVCIntro.Models
{
    public class Coffee
    {
        [Key]
        public int Id { get; set; } 
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
    }
}
