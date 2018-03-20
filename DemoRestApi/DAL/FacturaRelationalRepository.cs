using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoRestApi.Models;

namespace DemoRestApi.DAL
{
    public class FacturaRelationalRepo : IDataRepository
    { 
        public FacturaRelationalRepo(string ConnectionString ) {



        }

        public string Add(Factura Fac)
        {
            throw new NotImplementedException();
        }

        public Factura Get(string Id)
        {
            throw new NotImplementedException();
        }
    }
}