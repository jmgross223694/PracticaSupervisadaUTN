using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ListadoResultado
    {
        public string Operation_Date { get; set; }
        public string Payment_ID { get; set; }
        public string External_Reference { get; set; }
        public string Transaction_Amount { get; set; }

        public ListadoResultado()
        {
        }

        public ListadoResultado(string operation_Date, string payment_ID, string external_Reference, string transaction_Amount)
        {
            Operation_Date = operation_Date;
            Payment_ID = payment_ID;
            External_Reference = external_Reference;
            Transaction_Amount = transaction_Amount;
        }
    }
}
