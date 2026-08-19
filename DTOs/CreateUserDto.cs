using System.ComponentModel.DataAnnotations;

namespace UserManager.DTOs
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; } = "";
        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        public string Number { get; set; } = "";
    }
}