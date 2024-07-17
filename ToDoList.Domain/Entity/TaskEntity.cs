using ToDoList.Domain.Enum;//verbinden von prop Priority
namespace ToDoList.Domain.Entity;


public class TaskEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
}