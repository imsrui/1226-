using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category
    {
        [Key]
        [Display(Name = "编号")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "类别不能为空")]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "标题")]
        public string Title { get; set; }

        [Required(ErrorMessage = "修改时间不能为空")]
        [Column(TypeName = "DateTime")]
        [Display(Name = "修改时间")]
        public DateTime UpdateTime { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "创建时间不能为空")]
        [Column(TypeName = "DateTime")]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
