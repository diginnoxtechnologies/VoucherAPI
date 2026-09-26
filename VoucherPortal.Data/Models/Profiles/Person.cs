using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherPortal.Data.Models.Violations;

namespace VoucherPortal.Data.Models.Profiles
{
    public class Person:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string CivilId { get; set; } = null!;
        public ICollection<Violation>? Violations { get; set; }
    }
}
