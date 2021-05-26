using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entity
{
    public abstract class AbstractEntity
    {
        [Column(name: "ID", TypeName = "INTEGER")]
        [Key]
        public long ID { get; set; }
    }
}
