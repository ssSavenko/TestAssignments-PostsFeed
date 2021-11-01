using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.DAL
{
    public class DbPostData : DbBase, IPostData
    {
        public string Name { get; set; }

        public string Overview { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int PageNum { get; set; }

        public byte[] Icon { get; set; }
    }
}
