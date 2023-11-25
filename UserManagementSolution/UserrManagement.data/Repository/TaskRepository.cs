using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserrManagement.data.Entities;
using Task = UserrManagement.data.Entities.Task;

namespace UserrManagement.data.Repository
{
    public class TaskRepository
    {
        public User_DbContext user_DbContext { get; set; }

        public TaskRepository()
        {
            this.user_DbContext = new User_DbContext();
        }
        public List<Task> GetAllTask()
        {
            return this.user_DbContext.Tasks.ToList();
        }
        public void AddTask(Task task)
        {
            this.user_DbContext.Tasks.Add(task);
            this.user_DbContext.SaveChanges();
        }
        public void RemoveTask(int task)
        {
            var TaskToBeDeleted = this.user_DbContext.Tasks.Where(d => d.TaskId == task).FirstOrDefault();
            if (TaskToBeDeleted != null)
            {
                this.user_DbContext.Remove(TaskToBeDeleted);
                this.user_DbContext.SaveChanges();
            }
        }
        public List<Task> SearchTask(string Description)
        {
            var tasks = this.user_DbContext.Tasks.Where(b => b.Description == Description).ToList();
            return tasks;
        }
        public void UpdateTask(Task Tasks)
        {
            
            this.user_DbContext.Tasks.Update(Tasks);
            this.user_DbContext.SaveChanges();
        }

    }
}

   