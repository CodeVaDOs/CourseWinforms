using Course.Entity;
using Course.Entity.Enum;
using System;

namespace Course.Config
{
    public class LoggerContext
    {
        private readonly AuthContext authContext;
        private readonly DatabaseContext dbContext;

        public LoggerContext()
        {
            this.authContext = AuthContext.GetInstance();
            this.dbContext = new DatabaseContext();
        }

        private static readonly Lazy<LoggerContext> lazy =
       new Lazy<LoggerContext>(() => new LoggerContext());

        public static LoggerContext GetInstance()
        {
            return lazy.Value;
        }

        public void Log(EPriority priority, string message, User u = null)
        {
            Log log = new Log
            {
                Date = DateTime.Now,
                Message = message,
                Priority = priority,
                UserID = u != null ? u.ID : (authContext.IsAuthorized ? authContext.AuthorizedUser.ID : 0)
            };
            Console.WriteLine("AUTH ID");
            Console.WriteLine(authContext.AuthorizedUser.ID);
            dbContext.Logs.Add(log);
            dbContext.SaveChanges();
        }

        public void Error(string message, User u = null)
        {
            Log(EPriority.ERROR, message, u);
        }

        public void Info(string message, User u = null)
        {
            Log(EPriority.INFO, message, u);
        }
    }
}
