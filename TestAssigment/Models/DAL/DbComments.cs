using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssigment.Models.DAL
{
    public class DbComments: DbBase
    {
        public string UsersName { get; set; }

        public byte[] Icon { get; set; }

        public string Text { get; set; }

        public Guid PostsId { get; set; }
    }
}
