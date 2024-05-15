using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Table("logentries")]
    public class logentries
    {
        [Key]
        public int id {  get; set; }
        public string CorrelationId { get; set; }
        public DateTime DateUTC { get; set; }
        public int Thread {  get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
