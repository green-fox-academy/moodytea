using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Entities;

namespace ToDo.Repositories
{
    public class ToDoRep
    {
        ToDoContext ToDoContext;

        public ToDoRep(ToDoContext todoContext)
        {
            ToDoContext = todoContext;
        }
    }
}
