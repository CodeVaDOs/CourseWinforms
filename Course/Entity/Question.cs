using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entity
{
    [Table(name: "Question")]
    public class Question : AbstractEntity
    {
        [Column(name: "Body")]
        public string Body { get; set; }

        [Column(name: "Test_ID", TypeName = "INTEGER")]
        public long TestID { get; set; }

        [Column(name: "Right_Answer_ID", TypeName = "INTEGER")]
        public long RightAnswerID { get; set; }

        public virtual Test Test { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
