using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserrManagement.data.Repository;

namespace UserrManagementApi.Controllers
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
        [HttpGet("GetAllTasks")]
        public List<Task> GetAllTask()
        {
            var taskkss = this.taskRepository.GetAllTask();
            return taskss;
        }
        [HttpPost]
        public void AddTask(Task task)
        {
            this.taskRepository.AddTask(task);
        }
        [HttpDelete]
        public void RemoveTask(int TaskId)
        {
            this.taskRepository.RemoveTask(TaskId);
        }
        [HttpGet]
        public List<Task> SearchTask(string Description)
        {

            var ListOfTaskss = this.taskRepository.SearchTask(Description);
            return ListOfTaskss;
        }
        [HttpPut]
        public void UpdateTask(Task tasks)
        { 
            this.taskRepository.UpdateTask(tasks);
        }
    }
}
