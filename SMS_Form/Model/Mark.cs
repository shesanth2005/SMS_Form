using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Model
{
    internal class Mark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        
        public int ExamId { get; set; }
        public int Marks { get; set; }
        public string StudentName { get; set; }
       
        public string ExamName { get; set; }
   
        
    }
}
