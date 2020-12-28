using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        [Key]
        [Display(Name = "产品编号")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "产品标签不能为空")]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        [Display(Name = "产品标签")]
        public string Title { get; set; }

        [Required(ErrorMessage = "描述内容不能为空")]
        [StringLength(2000)]
        [Column(TypeName = "text")]
        [Display(Name = "描述内容")]
        public string Detail { get; set; }


        [Required(ErrorMessage = "产品价格不能为空")]

        [Column(TypeName = "decimal")]
        [Display(Name = "产品价格")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "产品数量不能为空")]

        [Column(TypeName = "int")]
        [Display(Name = "产品数量")]
        public int Counts { get; set; }


        [Required(ErrorMessage = "产品类别不能为空")]

        [Display(Name = "产品类别")]
        public Guid Cid { get; set; }

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
