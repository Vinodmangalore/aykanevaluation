using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_do_list.Data.Repository;

namespace To_do_list_Management.Controllers
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

        [HttpPost]
        public void AddTask(Task task)
        {
            this.taskRepository.AddTask(task);
        }

        [HttpDelete("{title:string}")]
        public void DeleteTask(string title)
        {
            this.taskRepository.DeleteTask(title);
        }

        [HttpPut("UpdateTask/{title:string}")]
        public void UpdateTask(string title, Task task)
        { 
            this.taskRepository.UpdateTask(title, task);
        }


    }
}
