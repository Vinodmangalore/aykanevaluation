using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_list.Data.TaskEntities;

namespace To_do_list.Data.Repository
{
    public class TaskRepository
    {
        public TaskContext taskContext { get; set; }

        public TaskRepository()
        {
            taskContext = new TaskContext();
        }

        public void AddTask(Task tasktbl)
        {
            this.taskContext.TaskTbls.Add(tasktbl);
            this.taskContext.SaveChanges();
        }

        public void DeleteTask(string title)
        {
            var deltask = taskContext.TaskTbls.Where(d => d.Title == title).FirstOrDefault();
            if (deltask != null)
            {
                this.taskContext.TrainTbls.Remove(deltask);
                this.taskContext.SaveChanges();
            }
        }
        public void UpdateTask(string title, TaskTbl taskTbl)
        {
            var uptask = this.taskContext.Tasktbls.Where(n => n.Title == title).FirstOrDefault();
            uptask.Title = taskTbl.title;
            uptask.Description = taskTbl.Description;
            uptask.DueDate = taskTbl.DueDate;
            uptask.PriorityLevel = taskTbl.PriorityLevel;
            uptask.CategoryId = taskTbl.CategoryId;
            this.taskContext.Tasktbl.Update(uptask);
            this.taskContext.SaveChanges();
        }
        
    }
}
