using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(500)]
        public string AboutContentFirst { get; set; }
        [StringLength(500)]
        public string AboutContetSecond { get; set; }
        [StringLength(100)]
        public string AboutImageFirst { get; set; }
        [StringLength(100)]
        public string AboutImageSecond { get; set; }

    }
}
