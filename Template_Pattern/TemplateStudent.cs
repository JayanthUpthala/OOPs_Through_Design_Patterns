using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal abstract class TemplateStudent
    {
        protected List<Student> _STList = new List<Student>();
        public List<Student> STList
        {
            get { return _STList; }
            set { _STList = value; }
        }
        public abstract void ReadStudents();
        public abstract void AssignGrades();
        public abstract void SortStudents();
        public abstract void StoreStudents();
        // algorithm steps
        public void ReadAndProcessStudents()
        {
            ReadStudents();
            AssignGrades();
            SortStudents();
            StoreStudents();
        }
    }
}
