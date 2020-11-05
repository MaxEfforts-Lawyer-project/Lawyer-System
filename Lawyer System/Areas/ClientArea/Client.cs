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
        public int NationalID { get; set; }



        [DisplayName("رقم الموبايل")]
        public int Phone { get; set; }



        public DateTime AuthorizationDate { get; set; }

    }
}
