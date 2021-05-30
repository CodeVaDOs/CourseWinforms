using Course.Entity.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    [Table(name: "User")]
    public class User : AbstractEntity
    {
        [Index(IsUnique = true)]
        [Column(name: "Login", TypeName = "VARCHAR")]
        public string Login { get; set; }

        [Column(name: "Password", TypeName = "VARCHAR")]
        public string Password { get; set; }

        [Column(name: "Role")]
        public ERole UserRole { get; set; }

        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}
