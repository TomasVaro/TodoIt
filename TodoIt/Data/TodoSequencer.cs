using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoSequencer
    {
        private static int personId;
        public int PersonId { get { return personId; } }

        public static int IncrementPersonId(int personId)
        {
            return personId = personId + 1;
        }

        public static int ResetPersonId()
        {
            return personId = 0;
        }
    }
}
