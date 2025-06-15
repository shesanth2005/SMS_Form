using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Model
{
    internal class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SubjectId { get; set; }

        public string SubjectName { get; set; }


    }
}
