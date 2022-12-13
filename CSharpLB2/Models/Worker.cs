using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLB2.Models.WorkerEnums;

namespace CSharpLB2.Models
{
    public class Worker
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IPN { get; set; }
        public Education Education { get; set; }
        public Position Position { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }
        
    }
}
