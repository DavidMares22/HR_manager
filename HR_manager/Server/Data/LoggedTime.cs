using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Data
{
    public class LoggedTime
    {
        public int Id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateLogged { get; set; }

        [Range(0, 12)]
        public Double Hours { get; set; }

        [ForeignKey("FK_LoggedTime_To_LoggedTimeType")]
        public virtual LoggedTimeType LoggedTimeType { get; set; }

    }
}
