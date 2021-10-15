using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class TodoItems
    {
        private static Todo[] todo = new Todo[0];
        public Todo[] Todo { get { return todo; } }

        public int Size()
        {
            return todo.Length;
        }
        public Todo[] FindAll()
        {
            return todo;
        }
        public Todo FindById(int todoId)
        {
            int i;
            for (i = 0; i < todo.Length; i++)
            {
                if (todo[i].TodoId == todoId)
                {
                    break;
                }
            }
            return todo[i];
        }
        public Todo CreateNewTodo(string description)
        {
            int todoId = TodoSequencer.NextTodoId();
            Todo newTodo = new Todo(todoId, description);
            Array.Resize(ref todo, todo.Length + 1);
            todo[todo.Length - 1] = newTodo;
            return newTodo;
        }
        public void Clear()
        {
            todo = new Todo[0];
        }
    }
}
