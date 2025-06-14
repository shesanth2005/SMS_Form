using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Model
{
    internal class Timetable
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        
        public string TimeSlot { get; set; }
        
        public string RommId { get; set; }
        public string RoomName { get; set; }


    }
}
