using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.Entity
{
    public abstract class AbstractEntity
    {
        [Column(name: "ID", TypeName = "INTEGER")]
        [Key]
        public long ID { get; set; }
    }
}
