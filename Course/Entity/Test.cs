using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entity
{
    [Table(name: "Test")]
    public class Test: AbstractEntity
    {
        [Index(IsUnique = true)]
        [Column(name: "Name")]
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}
