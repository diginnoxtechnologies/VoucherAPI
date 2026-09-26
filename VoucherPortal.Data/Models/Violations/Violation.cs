using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherPortal.Data.Models.Profiles;

namespace VoucherPortal.Data.Models.Violations
{
   
    public class Violation : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public ViolationType? ViolationType { get; set; }
        public int ViolationTypeId { get; set; }

        public Person? Person { get; set; }
        public int PersonId { get; set; }

    }
}
