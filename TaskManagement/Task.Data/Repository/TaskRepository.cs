using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Entities;

namespace Task.Data.Repository
{
    public class TaskRepository
    {
        CmsContext cmsContext { get; set; }
        public TaskRepository()
        {
            this.cmsContext = new CmsContext();
        }
        public List<TblTask> GetAllTasksSortedByDueDate()
        {
            return this.cmsContext.TblTasks.OrderBy(task => task.DueDate).ToList();
        }
        public List<TblTask> GetAllTasksSortedByPriority()
        {
            return this.cmsContext.TblTasks.OrderBy(task => task.PriorityLevel).ToList();
        }

        public void AddTask(TblTask task)
        {
            this.cmsContext.TblTasks.Add(task);
            this.cmsContext.SaveChanges();
        }
        public void RemoveTask(int taskId)
        {
            var removedTask = this.cmsContext.TblTasks.Where(b => b.Id ==taskId).FirstOrDefault();
            if (removedTask != null)
            {
                this.cmsContext.Remove(removedTask);
                this.cmsContext.SaveChanges();
            }
        }
        public List<TblTask> GetTaskById(int taskid)
        {
            var taskById = this.cmsContext.TblTasks.Where(b => b.Id == taskid).ToList();
            return taskById;
        }
        public void UpdateTask(int taskId, TblTask updatedTask)
        {
            var existingTask = this.cmsContext.TblTasks.FirstOrDefault(t => t.Id == taskId);

            if (existingTask != null)
            {
                existingTask.Title = updatedTask.Title;
                existingTask.Description = updatedTask.Description;
                existingTask.DueDate = updatedTask.DueDate;
                existingTask.PriorityLevel = updatedTask.PriorityLevel;
                this.cmsContext.SaveChanges();
            }
        }



    }
}
