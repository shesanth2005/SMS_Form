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

        public string Day { get; set; }

        

        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public int RoomId { get; set; }
        public string RoomName { get; set; }


    }
}
