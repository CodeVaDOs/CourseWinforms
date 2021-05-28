using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entity
{
    [Table(name: "Answer")]
    public class Answer : AbstractEntity
    {
        [Column(name: "Body")]
        public string Body { get; set; }

        [Column(name: "Question_ID")]
        public long QuestionID { get; set; }

        public virtual Question Question { get; set; }
    }
}
