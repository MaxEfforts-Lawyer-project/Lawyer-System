using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer_System.Areas.sessionarea
{
    class session
    {
        public int Id { get; set; }
        public string dession { get; set; }

        public DateTime date { get; set; }

        [ForeignKey("lawsuit")]
        [Key, Column(Order = 2)]
        public int LawsuiteId { get; set; }
        public Lawsuit lawsuit { get; set; }
    }
}
