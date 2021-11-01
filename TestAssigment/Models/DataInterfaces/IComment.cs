using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssignment.Models.DataInterfaces
{
    public interface IComment
    {
        public string UsersName { get; set; }

        public byte[] Icon { get; set; }

        public string Text { get; set; }

        public Guid PostsId { get; set; }
    }
}
