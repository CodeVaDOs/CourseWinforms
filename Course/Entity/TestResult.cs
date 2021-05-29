using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
