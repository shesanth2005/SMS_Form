using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Model
{
    internal class Lecturer
    {
        public int Id {  get; set; }    
        public string Name { get; set; }
        public string Address { get; set; }

        public string Telephone { get; set; }


        public int UserId { get; set; }
    }
}
