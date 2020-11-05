using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer_System.Areas
{
    class IDs
    {
        public int Id { get; set; }

        [ForeignKey("Client")]
        [Key, Column(Order = 0)]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("document")]
        [Key, Column(Order = 1)]
        public int DocumentId { get; set; }
        public Document document { get; set; }


        [ForeignKey("lawsuit")]
        [Key, Column(Order = 2)]
        public int LawsuiteId { get; set; }
        public Lawsuit lawsuit { get; set; }
    }
}
