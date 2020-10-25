using System.ComponentModel.DataAnnotations;

namespace WebApiCore3.DTOs
{
    public class CommandReadDTO
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
    }
}