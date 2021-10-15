using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;
        public int PersonId { get { return personId; } }

        public static int NextPersonId()
        {
            return ++personId;
        }

        public static int Reset()
        {
            return personId = 0;
        }
    }
}
