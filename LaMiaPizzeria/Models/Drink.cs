using LaMiaPizzeria.Models.CustomValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeria.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Questo campo è obbligatorio!")]
        [StringLength(25, ErrorMessage = "Il nome non può essere più lungo di 25 caratteri!")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio!")]
        [StringLength(200, ErrorMessage = "La descrizione no può essere più lunga di 200 caratteri!")]


        public string Description { get; set; }

        [Required(ErrorMessage = "Questo campo è obbligatorio!")]
        [NoGifts]
        [NoNegative]
        [NoPriceForPoors]
        public int Price { get; set; }


        public Drink(int id, string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public Drink() { }
    }


}
