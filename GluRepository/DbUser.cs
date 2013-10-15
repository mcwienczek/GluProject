using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluRepository
{
    public class DbUser
    {
        public int DbUserId { get; set; }
        [MaxLength(25)]
        public string UserName { get; set; }
        [MaxLength(128)]
        public string Password { get; set; }
        
        public decimal Weight { get; set; }
    }
}
