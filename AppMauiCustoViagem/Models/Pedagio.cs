using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMauiCustoViagem.Models
{
    public class Pedagio
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Local { get; set; }
        public double Valor { get; set; }        
        public double Total { get; set; }

    }
}
