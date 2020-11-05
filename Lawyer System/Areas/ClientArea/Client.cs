using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lawyer_System.Areas
{
    class Client
    {
        public int Id { get; set; }
        [DisplayName("الاسم")]
        public string Name { get; set; }
        [DisplayName("الرقم القومي")]
        public string NationalID { get; set; }
        [DisplayName("رقم الموبايل")]
        public string Phone { get; set; }
        [DisplayName("رقم التوكيل")]
        public string tawkelNumber { get; set; }
        public DateTime AuthorizationDate { get; set; }
        public ICollection<Lawsuit> lawsuits { get; set; }

    }
}
