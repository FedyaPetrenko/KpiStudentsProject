using System;
using System.Collections.Generic;

namespace KpiStudents.Data
{
    public partial class Faculty
    {
        public Faculty()
        {
            Cafedras = new HashSet<Cafedra>();
        }

        public int FacultyId { get; set; }
        public string FacultyName { get; set; }

        public ICollection<Cafedra> Cafedras { get; set; }
    }
}
