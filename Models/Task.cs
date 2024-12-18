using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstExcercise1.Models;

internal class Task
{
    public int Id { get; set; }
    public string Titel { get; set; }
    //public Person? Responsible { get; set; }
    public bool IsDone { get; set; }
    public Task()
    {
        
    }
    public Task(string title)
    {
        Titel = title;
        IsDone = false;
    }

}

