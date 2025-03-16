using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace webFood.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
