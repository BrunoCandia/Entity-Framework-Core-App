using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Framework_Core_App.Models;

namespace Entity_Framework_Core_App.Data
{
    public static class DbInit
    {
        public static void InitializeWithFakeData(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Contacts.Any())
            {
                context.Contacts.Add(new Contact { FirstName = "John", LastName = "Smith", Email = "john.smith@hotmail.com" });
                context.Contacts.Add(new Contact { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@hotmail.com" });
                context.Contacts.Add(new Contact { FirstName = "James", LastName = "Ford", Email = "james.ford@hotmail.com" });
            }

            if (!context.ToDoS.Any())
            {
                context.ToDoS.Add(new ToDo { Text = "Wash the dishes", IsCompleted = true });
                context.ToDoS.Add(new ToDo { Text = "Take out the trash", IsCompleted = true });
                context.ToDoS.Add(new ToDo { Text = "Study for exams", IsCompleted = true });
            }

            context.SaveChanges();
        }
    }
}
