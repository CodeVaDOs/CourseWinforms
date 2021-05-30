using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    [Table(name: "Test")]
    public class Test : AbstractEntity
    {
        [Index(IsUnique = true)]
        [Column(name: "Name")]
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}
