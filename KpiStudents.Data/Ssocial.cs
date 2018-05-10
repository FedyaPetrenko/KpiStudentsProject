using System;
using System.Collections.Generic;

namespace KpiStudents.Data
{
    public partial class Ssocial
    {
        public Ssocial()
        {
            Persons = new HashSet<Person>();
        }

        public int SocialId { get; set; }
        public string SocialName { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}
