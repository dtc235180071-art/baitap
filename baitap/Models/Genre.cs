using System.ComponentModel.DataAnnotations;

namespace baitap.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        [Display(Name = "Thể loại")]
        public string Name { get; set; }

        public ICollection<Movie>? Movies { get; set; }
    }
}