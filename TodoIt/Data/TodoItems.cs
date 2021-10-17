using System;
using System.Collections.Generic;
using System.Linq;
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
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] todoSameDone = new Todo[] { };
            foreach (Todo t in Todo)
            {
                if (doneStatus == t.Done)
                {
                    Array.Resize(ref todoSameDone, todoSameDone.Length + 1);
                    todoSameDone[todoSameDone.Length - 1] = t;
                }
            }
            return todoSameDone;
        }
        public Todo[] FindByAssignee(int personId)
        {
            Todo[] todoSamePersonId = new Todo[] { };
            foreach (Todo t in Todo)
            {
                if (personId == t.Assignee.PersonId)
                {
                    Array.Resize(ref todoSamePersonId, todoSamePersonId.Length + 1);
                    todoSamePersonId[todoSamePersonId.Length - 1] = t;
                }
            }
            return todoSamePersonId;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            Todo[] todoSameAssignee = new Todo[] { };
            foreach (Todo t in Todo)
            {
                if (assignee == t.Assignee)
                {
                    Array.Resize(ref todoSameAssignee, todoSameAssignee.Length + 1);
                    todoSameAssignee[todoSameAssignee.Length - 1] = t;
                }
            }
            return todoSameAssignee;
        }
        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] todoUnassigned = new Todo[] { };
            foreach (Todo t in Todo)
            {
                if (t.Assignee == null)
                {
                    Array.Resize(ref todoUnassigned, todoUnassigned.Length + 1);
                    todoUnassigned[todoUnassigned.Length - 1] = t;
                }
            }
            return todoUnassigned;
        }
        public void RemoveTodoItemFromArray(Todo todoToRemove)
        {
            for (int i = 0; i < todo.Length; i++)
            {
                if (Todo[i].TodoId == todoToRemove.TodoId
                    && Todo[i].Description == todoToRemove.Description)
                {
                    todo = todo.Where((source, index) => index != i).ToArray();
                }
            }
        }
    }
}
