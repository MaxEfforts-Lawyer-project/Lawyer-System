using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer_System.Areas
{
    class Lawsuit
    {
        public int Id { get; set; }
        
        [DisplayName("رقم الدعوي")]
        public int LawsuitNumber { get; set; }

        [DisplayName("سنة")]
        public int year { get; set; }
        
        [DisplayName("تاريخ الجلسة")]
        public DateTime date { get; set; }


        
    }
}
