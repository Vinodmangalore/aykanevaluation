using System;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Data.Entities;

namespace ToDo.Data.Entities.Repository
{
    public class ToDoRepository
    {
        private readonly ToDoListContext _toDoDBContext;

        public ToDoRepository()
        {
            _toDoDBContext = new ToDoListContext();
        }

        public void AddTask(Task task)
        {
            Task task1 = new Task();
            task1.Category = task.Category;
            task1.Title = task.Title;
            task1.TaskDescription = task.TaskDescription;
            task1.DueDate = task.DueDate;
            task1.PriorityLevel = task.PriorityLevel;

            _toDoDBContext.Tasks.Add(task);
            _toDoDBContext.SaveChanges();
        }

        public Task GetTaskByTitle(Task task)
        {
            return _toDoDBContext.Tasks.FirstOrDefault(t => t.Title == task.Title);
        }

        public void UpdateTask(Task updatedTask)
        {
            var existingTask = _toDoDBContext.Tasks.FirstOrDefault(t => t.Title == updatedTask.Title);
            if (existingTask != null)
            {
                existingTask.Title = updatedTask.Title;
                existingTask.TaskDescription = updatedTask.TaskDescription;
                existingTask.DueDate = updatedTask.DueDate;
                existingTask.PriorityLevel = updatedTask.PriorityLevel;
                existingTask.Category = updatedTask.Category;
                
                _toDoDBContext.SaveChanges();
            }
        }

        public void DeleteTask(Task task)
        {
            var taskToDelete = _toDoDBContext.Tasks.FirstOrDefault(t => t.Title == task.Title);
            if (taskToDelete != null)
            {
                _toDoDBContext.Tasks.Remove(taskToDelete);
                _toDoDBContext.SaveChanges();
            }
        }

        
    }
}