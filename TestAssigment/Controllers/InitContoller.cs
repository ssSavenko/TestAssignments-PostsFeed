using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using TestAssigment.Models.DAL;
using TestAssignment.Init; 
using Microsoft.AspNetCore.Mvc;

namespace TestAssignment.Controllers
{
#if DEBUG 
    [ApiController]
    [Route("Init")] 
    public class InitContoller
    {

        DatabseContext context;

        public InitContoller(DatabseContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public void Get()
        { 
            new InitDB(context);
        }
    }
#endif
}
