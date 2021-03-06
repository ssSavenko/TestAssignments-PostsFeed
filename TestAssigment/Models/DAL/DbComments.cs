using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.DAL
{
    public class DbComments: DbBase, IComment
    {
        public string UsersName { get; set; }

        public byte[] Icon { get; set; }

        public string Text { get; set; }

        public Guid PostsId { get; set; }
    }
}
