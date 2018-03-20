using DemoRestApi.DAL;
using DemoRestApi.Messages;
using DemoRestApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoRestApi.Controllers
{
    public class FacturaController : ApiController
    {

        public FacturaController() {
            var emailHelper = new EmailHelper();
            var voiceHelper = new VoiceHelper();
            var smsHelper = new SMSHelper();
            IDataRepository repo = new FacturaRelationalRepo(ConfigurationManager.ConnectionStrings[""].ConnectionString);
            FacturaHelper facturaHelper = new FacturaHelper(repo,smsHelper,emailHelper,voiceHelper);
        }
        


        // GET: api/Factura
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Factura/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Factura
        public void Post([FromBody]string value)
        {


        }

        // PUT: api/Factura/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Factura/5
        public void Delete(int id)
        {
        }
    }
}
