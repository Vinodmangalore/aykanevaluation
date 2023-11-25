using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Data.Repository;
using Task.Data.Entities;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public TaskRepository taskRepository { get; set; }
        public UserController()
        {
            this.taskRepository = new TaskRepository();
        }
        [HttpGet("SortedBasedOnDueDate")]
        public List<TblTask> GetTasksSortedByDueDate()
        {
            return this.taskRepository.GetAllTasksSortedByDueDate();
        }

        [HttpGet("SortedBasedOnPriority")]
        public List<TblTask> GetTasksSortedByPriority()
        {
            return this.taskRepository.GetAllTasksSortedByPriority();
        }

        [HttpPost]
        public void AddTask(TaskModel task)
        {
            TblTask tbltask = new TblTask();
            tbltask.Id = task.Id;
            tbltask.Title = task.Title;
            tbltask.Description= task.Description;
            tbltask.DueDate = task.DueDate;
            tbltask.PriorityLevel= task.PriorityLevel;
            this.taskRepository.AddTask(tbltask);
        }
        [HttpDelete]
        public void RemoveTask(int taskid)
        {
            this.taskRepository.RemoveTask(taskid);
        }
        [HttpGet("Id")]
        public List<TblTask> GetTaskById(int taskid)
        {
            return this.taskRepository.GetTaskById(taskid);
        }
        [HttpPut]
        public void UpdatedTask(int taskid, TblTask task)
        {
            TblTask tbltask = new TblTask();
            tbltask.Id = task.Id;
            tbltask.Title = task.Title;
            tbltask.Description = task.Description;
            tbltask.DueDate = task.DueDate;
            tbltask.PriorityLevel = task.PriorityLevel;
            this.taskRepository.UpdateTask(taskid,task);
        }
    }
}
