using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.data.Entities;
using System.Threading.Tasks;
namespace TaskManagement.data.Repositories
{
    public class TaskRepository
    {
       

        TmsContext tmsContext { get; set; }
        public TaskRepository()
        {
            this.tmsContext = new TmsContext();
        }
        public List<TaskTable> GetAllTask()
        {
           
          // return task.OrderBy(t => t.DueDate).ToList();
        
           return this.tmsContext.TaskTables.ToList();
        }
        public void AddTask(TaskTable task)
        {
            this.tmsContext.TaskTables.Add(task);
            this.tmsContext.SaveChanges();
        }
        public void RemoveTask(string title)
        {
            var removedTask = this.tmsContext.TaskTables.Where(t => t.Title == title).FirstOrDefault();
            if (removedTask != null)
            {
                this.tmsContext.Remove(removedTask);
                this.tmsContext.SaveChanges();
            }
        }
        public List<TaskTable> GetTaskByTitle(string title)
        {
            var taskByTitle = this.tmsContext.TaskTables.Where(t => t.Title == title).ToList();
            return taskByTitle;
        }
        public void EditTask(TaskTable title)
        {

            this.tmsContext.Update(title);
            this.tmsContext.SaveChanges();

        }

        
    }
}

