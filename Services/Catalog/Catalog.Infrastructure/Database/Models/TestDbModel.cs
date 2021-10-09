using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Catalog.Infrastructure.Database.Models
{
    public class TestDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string TestVal1 { get; set; }
        public string TestVal2 { get; set; }
    }
}
