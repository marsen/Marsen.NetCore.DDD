using Marsen.NetCore.DDD.Application.Common.Mappings;
using Marsen.NetCore.DDD.Domain.Entities;
using System.Collections.Generic;

namespace Marsen.NetCore.DDD.Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
}
