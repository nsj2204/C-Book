using System.Collections.Generic;

namespace TodoApp.Models
{
    /// <summary>
    /// 모델 클래스
    /// </summary>
    public class Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    public class TodoRepository : ITodoRepository
    {
        public void Add(Todo model)
        {
            throw new System.NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
    public class TodoRepositorySqlServer : ITodoRepository
    {
        public void Add(Todo model)
        {
            throw new System.NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }

}
