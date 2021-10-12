using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoSequencer
    {
        private static int personId;
        public int PersonId { get { return personId; } }

        public static int ResetPersonId()
        {
            return personId = 0;
        }
    }
}
