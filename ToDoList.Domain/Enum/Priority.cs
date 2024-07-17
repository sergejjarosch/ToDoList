using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Enum;

//Priorität der Aufgaben
public enum Priority
{
    [Display(Name = "Einfach")]
    Easy = 0,
    [Display(Name = "Wichtig")]
    Medium = 1,
    [Display(Name = "Kritisch")]
    High = 2
}