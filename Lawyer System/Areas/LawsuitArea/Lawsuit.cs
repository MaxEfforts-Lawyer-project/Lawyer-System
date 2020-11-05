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
        public string LawsuitNumber { get; set; }

        [DisplayName("سنة")]
        public string year { get; set; }
        
        [DisplayName("تاريخ الجلسة")]
        public DateTime date { get; set; }
        [DisplayName("نوع الدعوى")]
        public string LawsuitType { get; set; }
        [DisplayName("تفاصيل الدعوى")]
        public string LawsuitDetails { get; set; }
        public ICollection<Client> clients { get; set; }
        public ICollection<Document> documents { get; set; }



    }
}
