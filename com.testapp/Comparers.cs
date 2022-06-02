using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.testapp
{
   class IdComparer : IComparer<Course>
    {
        public int Compare(Course c1, Course c2)
            { return c1.Id.CompareTo(c2.Id); }
    }


    class StartDateComparer : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Course c1, Course c2)
        {
            return c1.StartDate.CompareTo(c2.StartDate);
        }
    }
}
