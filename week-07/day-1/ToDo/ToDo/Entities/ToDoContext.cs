﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Entities
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDoClass> ToDos { get;set; }

        public void Adding(ToDoClass toDoClass)
        {
            ToDos.Add(toDoClass);
            this.SaveChanges();
        }

        public void Deleting(ToDoClass toDoClass)
        {
            ToDos.Remove(toDoClass);
            this.SaveChanges();
        }
    }
}
