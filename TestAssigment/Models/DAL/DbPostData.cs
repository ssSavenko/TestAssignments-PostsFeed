using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssigment.Models.DAL
{
    public class DbPostData : DbBase
    {
        public string Name { get; set; }

        public string Overview { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int PageNum { get; set; }

        public byte[] Icon { get; set; }
    }
}
