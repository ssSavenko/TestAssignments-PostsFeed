using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.DAL
{
    public class DbPostItem : DbBase, IPostItem
    {
        private bool isHorizontal = false;
        public string Text { get; set; }

        public byte[] Image { get; set; }


        public int NumberOfPostItem { get; set; }

        public Guid PostId { get; set; }

        public bool IsHorizontal
        {
            get
            {
                return isHorizontal;
            }
            set
            {
                isHorizontal = value;
            }
        }
    }
}
