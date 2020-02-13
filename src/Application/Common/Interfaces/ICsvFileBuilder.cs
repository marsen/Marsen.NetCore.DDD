using Marsen.NetCore.DDD.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Marsen.NetCore.DDD.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
