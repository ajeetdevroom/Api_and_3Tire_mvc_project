using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RikeshServices_API.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string StdID { get; set; }
        public string StdName { get; set; }
        public string StdAddress { get; set; }
        public string stdClass { get; set; }
        public string StdMobile { get; set; }
        public string StdEmail { get; set; }
    }
}
