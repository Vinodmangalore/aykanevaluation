using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_Do_List_API.Models;
using ToDo.Data.Entities.Repository;

namespace To_Do_List_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        public ToDoRepository toDoListRepository { get; set; }

        public TodoController()
        {
            this.toDoListRepository = new ToDoRepository();
        }

        [HttpPost("AddTask")]
        public void AddTask(Tasks task)
        {
            Tasks task1 = new Tasks();
            task1.Category = task.Category;
            task1.Title = task.Title;
            task1.Description = task.Description;
            task1.DueDate = task.DueDate;
            task1.PriorityLevel = task.PriorityLevel;
        }

        public void DeleteTask(Tasks task)
        {
            this.toDoListRepository.DeleteTask();
        }
        public Tasks GetTasks(String Title)
        {
            return this.toDoListRepository.GetTask();
        }

    }
}