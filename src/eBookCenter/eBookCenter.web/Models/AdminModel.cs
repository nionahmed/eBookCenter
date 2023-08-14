using System.ComponentModel.DataAnnotations;

namespace eBookCenter.web.Models
{
    public class AdminModel
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
