using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    [Table(name: "TestResult")]
    public class TestResult : AbstractEntity
    {
        [Column(name: "PercentOfRightAnswers")]
        public int PercentOfRightAnswers { get; set; }

        [Column(name: "Test_ID", TypeName = "INTEGER")]
        public long TestID { get; set; }

        [Column(name: "User_ID", TypeName = "INTEGER")]
        public long UserID { get; set; }

        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date { get; set; }

        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
