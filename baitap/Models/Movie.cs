using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baitap.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên phim không được để trống")]
        [Display(Name = "Tên phim")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày phát hành")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Thời lượng (phút)")]
        public int Duration { get; set; }

        [Display(Name = "Thể loại")]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }
    }
}