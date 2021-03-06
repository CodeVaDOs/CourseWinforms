using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    [Table(name: "Answer")]
    public class Answer : AbstractEntity
    {
        [Column(name: "Body")]
        public string Body { get; set; }

        [Column(name: "Question_ID")]
        public long QuestionID { get; set; }

        [Column(name: "IsRightAnswer")]
        public bool IsRightAnswer { get; set; }

        public virtual Question Question { get; set; }

    }
}
