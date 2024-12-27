using System.ComponentModel.DataAnnotations;

namespace eticaret_uygulamai.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name ="Kategori No")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string? CategoryName { get; set; }
        [Display(Name ="Kategori Adı")]
        virtual public List<Products>? Products { get; set; }

    }
}
