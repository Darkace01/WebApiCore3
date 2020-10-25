using System.ComponentModel.DataAnnotations;

namespace WebApiCore3.DTOs
{
    public class CommandCreateDTO
    {
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }

    public class CommandReadDTO
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
    }

    public class CommandUpdateDTO
    {
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}