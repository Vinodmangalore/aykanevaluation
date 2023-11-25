using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.data.Repositories;
using TaskManagement.data.Entities;
using TaskManagementAPI.Models;
namespace TaskManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        public TaskRepository taskRepository { get; set; }
        public TaskController()
        {
            this.taskRepository = new TaskRepository();
        }
        [HttpGet]
       public List<TaskTable> GetAllTask()
        {
            /*
           
            public ActionResult<IEnumerable<TaskTable>> GetAllTask()
            {
                var task = this.taskRepository.GetAllTask();
                var sortedTasks = task.OrderBy(t => t.DueDate).ToList();

                return Ok(sortedTasks);
            }*/
            
            return this.taskRepository.GetAllTask();
        }

        [HttpPost]
        public void AddTask(TaskTable task)
        {
            TaskTable taskTable = new TaskTable();
            taskTable.Title = task.Title;
            taskTable.Description = task.Description;
            taskTable.DueDate = task.DueDate;
            taskTable.PriorityLevel = task.PriorityLevel;

            this.taskRepository.AddTask(taskTable);
        }
        [HttpDelete]
        public void RemoveTask(string title)
        {
            this.taskRepository.RemoveTask(title);
        }
        [HttpGet("Title")]
        public List<TaskTable> GetTaskByTitle(string title)
        {
            return this.taskRepository.GetTaskByTitle(title);
        }
        [HttpPut]
        public void EditTask(TaskTable title)
        {
            TaskTable taskTable = new TaskTable();
            taskTable.Title = title.Title;
            taskTable.Description = title.Description;
            taskTable.DueDate = title.DueDate;
            taskTable.PriorityLevel = title.PriorityLevel;
            this.taskRepository.EditTask(taskTable);
        }
    }
}


