using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssignment.Models.DataInterfaces
{
    public  interface IPostItem
    {
        public string Text { get; set; }

        public byte[] Image { get; set; }


        public int NumberOfPostItem { get; set; }

        public Guid PostId { get; set; }

        public bool IsHorizontal { get; set; }
    }
}
