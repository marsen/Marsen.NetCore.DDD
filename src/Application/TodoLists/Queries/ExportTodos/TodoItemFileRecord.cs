using Marsen.NetCore.DDD.Application.Common.Mappings;
using Marsen.NetCore.DDD.Domain.Entities;

namespace Marsen.NetCore.DDD.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
