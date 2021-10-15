using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public int TodoId { get { return todoId; } }

        public static int NextTodoId()
        {
            return ++todoId;
        }

        public static int ResetTodoId()
        {
            return todoId = 0;
        }
    }
}
