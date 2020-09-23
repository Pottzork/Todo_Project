using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public class SetCurrentUser
    {
        public static int Id { get; set; }      

        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Phone { get; set; }
        public static bool IsAuthenticated { get; set; } = false;
    }
}
