using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssignment.Models.DataInterfaces
{
    public interface IPostData
    {
        public string Name { get; set; }

        public string Overview { get; set; } 
        public int PageNum { get; set; }

        public byte[] Icon { get; set; }
    }
}
