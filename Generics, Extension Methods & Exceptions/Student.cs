using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics_1216098.MyEnums;

namespace Generics_1216098
{
    internal class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Test1Score { get; set; }
        public int Test2Score { get; set; }


        #region IComparable<Student> Members
        public int CompareTo(Student st, SORTFIELD sField)
        {
            int res = 0;
            switch (sField)
            {
                case SORTFIELD.FIRSTNAME:
                    res = this.FirstName.CompareTo(st.FirstName);
                    break;
                case SORTFIELD.LASTNAME:
                    res = this.LastName.CompareTo(st.LastName);
                    break;
                case SORTFIELD.ID:
                    res = this.Id.CompareTo(st.Id);
                    break;
                case SORTFIELD.TEST1SCORE:
                    res = this.Test1Score.CompareTo(st.Test1Score);
                    break;
                case SORTFIELD.TEST2SCORE:
                    res = this.Test2Score.CompareTo(st.Test2Score);
                    break;
            }
            return res;
        }

        public int CompareTo(Student? other)
        {
            throw new NotImplementedException();
        }
        #endregion

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Id.ToString() + " " + Test1Score.ToString() + " " + Test2Score.ToString();
        }
    }
}
