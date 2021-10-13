using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;
        public int PersonId { get { return personId; } }

        public static int NextPersonId(int personId)
        {
            return personId = personId + 1;
        }

        public static int Reset()
        {
            return personId = 0;
        }
    }
}
