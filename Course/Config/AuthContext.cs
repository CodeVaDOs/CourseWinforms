using Course.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Course.Config
{
    public class AuthContext
    {
        public AuthContext()
        {
            Console.WriteLine("AUTH CONTEXT");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        private static readonly Lazy<AuthContext> lazy =
       new Lazy<AuthContext>(() => new AuthContext());


        public static AuthContext GetInstance()
        {
            return lazy.Value;
        }

        public User AuthorizedUser { get; set; }
        public bool IsAuthorized { get; set; }

        public void Authorize(User user) {
            AuthorizedUser = user;
            IsAuthorized = true;
        }
    }
}
