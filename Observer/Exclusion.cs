using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Exclusion
    {
        string _filter;
        int _id;

        static int counter;

        public Exclusion(string filter)
        {
            _filter = filter;
            _id = counter++;
        }

        public string Filter
        {
            get
            {
                return _filter;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public override string ToString()
        {
            return _filter;
        }
    }
}
