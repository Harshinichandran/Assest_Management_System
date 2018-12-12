using Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public class Reports
    {
        public Resources resource { get; set; }

        public Facility facility { get; set; }

        public IQueryable<Resources> resourceCollection { get; set; }

        public IQueryable<Facility> facilityCollection { get; set; }
    }
}
