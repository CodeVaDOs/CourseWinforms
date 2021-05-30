using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    [Table(name: "Question")]
    public class Question : AbstractEntity
    {
        [Column(name: "Body")]
        public string Body { get; set; }

        [Column(name: "Test_ID", TypeName = "INTEGER")]
        public long TestID { get; set; }

        public virtual Test Test { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
