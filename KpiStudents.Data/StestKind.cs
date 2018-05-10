using System;
using System.Collections.Generic;

namespace KpiStudents.Data
{
    public partial class StestKind
    {
        public StestKind()
        {
            TeachPlans = new HashSet<TeachPlan>();
        }

        public int TestKindId { get; set; }
        public string TestKindName { get; set; }

        public ICollection<TeachPlan> TeachPlans { get; set; }
    }
}
