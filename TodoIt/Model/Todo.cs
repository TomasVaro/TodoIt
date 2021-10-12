using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Todo
    {
        private readonly int todoId;
        public int TodoId { get { return todoId; } }

        private string description;
        public string Description { get { return description; } }

        private bool done;
        public bool Done { get { return done; } }

        private Person assignee;
        public Person Assignee { get { return assignee; } }

        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;
        } 
    }
}
