using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    //Movie类包括
    public class Movie
    {
        //数据库需要的ID字段获取主键
        public int ID { get; set; }
        public string Title { get; set; }

        //DataType属性指定数据类型（日期）通过此特性：
        //1、用户无需再数据字段中输入时间信息
        //2、仅显示日期，而非时间信息
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        

        public decimal Price { get; set; }
    }
}
