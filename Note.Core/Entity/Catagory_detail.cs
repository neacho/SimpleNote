using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Note.Core.Entity
{
    public class Catagory_detail
    {
        [Key, Column(Order = 0)]
        public Int64 Catagory_ID { get; set; }
        [Key, Column(Order = 1)]
        public Int64 File_ID { get; set; }
    }
}
