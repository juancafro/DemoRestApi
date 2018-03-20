using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Util.Internal.PlatformServices;
using CloudPattern.AWS.Contracts
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRestApi.DAL.Services
{
    public class DynamoService :ITableDataService
    {
        public readonly DynamoDBContext dbcontext;
        public AmazonDynamoDBClient dynamoclient;

        public DynamoService()
        {
            dynamoclient = new AmazonDynamoDBClient();
            dbcontext = new DynamoDBContext(dynamoclient, new DynamoDBContextConfig
            {
                ConsistentRead = true,
                SkipVersionCheck = true
            });


        }

        public void Store<T>(T item) where T : new() {
            dbcontext.Save(item);
           
        }

        public T GetItem<T>(string key) where T : class
        {
            return dbcontext.Load<T>(key);

        }



    }
}