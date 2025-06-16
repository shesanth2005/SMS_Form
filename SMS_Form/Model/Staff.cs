using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Model
{
    internal class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string StaffRole { get; set; } // Role of the staff (e.g., Teacher, Administrator, etc.)

        public int UserId { get; set; } // Foreign key to Users table

    }
}
