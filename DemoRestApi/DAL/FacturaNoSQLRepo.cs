using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoRestApi.DAL.Services;
using DemoRestApi.Models;

namespace DemoRestApi.DAL
{
    public class FacturaNoSQLRepo : IDataRepository
    {
       ITableDataService dbservice;
        public FacturaNoSQLRepo(string service) {
            switch (service) {
                case "dynamo":
                    dbservice = new DynamoService();
                    break;
                default:
                    dbservice = new DynamoService();
                    break;
            }
        }

        public string Add(Factura Fac)
        {
            dbservice.Store(Fac);
            return "some object";
        }

        public Factura Get(string key)
        {
            return dbservice.GetItem(key);
        }
    }
}