using Course.Entity.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    [Table(name: "Log")]
    public class Log : AbstractEntity
    {
        [Column(name: "User_ID", TypeName = "INTEGER")]
        public long UserID { get; set; }

        public virtual User User { get; set; }

        [Column(name: "Priority")]
        public EPriority Priority { get; set; }

        [Column(name: "Message", TypeName = "VARCHAR")]
        public string Message { get; set; }

        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date { get; set; }
    }
}
