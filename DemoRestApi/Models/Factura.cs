using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRestApi.Models
{
    [DynamoDBTable("Factura")]
    public class Factura
    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        public string Identificacion { get; set; }

        public string NombreAsegurado{ get; set;  }

        public string Seguro { get; set; } = "SUSTRACCION DE REMESAS";

        public string Aseguradora { get; set; }

        public string Oficina { get; set; }

        public double ValorAsegurado{ get; set;  }

        public double ValorPrimaTotal { get; set; }

        public DateTime FechaDeTrasaccion { get; set; }

        public string Ciudad { get; set; }

        public string Talon { get; set; }

        public string Tomador { get; set; } = "BANCO DAVIVIENDA";
    }
}