using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssigment.Models.DAL
{
    public class DbPostItem : DbBase
    {
        public string Text { get; set; }

        public byte[] Image { get; set; }

        private bool isHorizontal = false;

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
