using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lawyer_System.Areas
{
    class Opponent
    {
        public int Id { get; set; }

        [DisplayName(" اسم الخصم")]
        public string Name { get; set; }


        [DisplayName("ملاحظات")]
        public string Notes { get; set; }

        [ForeignKey("lawsuit")]
        public int LawsuitId { get; set; }
        public Lawsuit lawsuit { get; set; }
    }
}
