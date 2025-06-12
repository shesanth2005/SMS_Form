using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Model
{
    internal class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public int CourseId { get; set; }

        public string CourseName { get; set; }
    }
}
