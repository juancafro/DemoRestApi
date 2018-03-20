using DemoRestApi.DAL;
using DemoRestApi.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRestApi.Models
{
    public class FacturaHelper
    {
        IDataRepository repository;
        VoiceHelper vHelper;
        SMSHelper smsHelper;
        EmailHelper emailHelper;

        public FacturaHelper(IDataRepository repo , SMSHelper smsh , EmailHelper eh , VoiceHelper vh){
            repository = repo;
            vHelper = vh;
            smsHelper = smsh;
            emailHelper = eh;
        }

        public Factura GetItem( string id) {
            Factura fac=repository.Get(id);
            return fac;
        }

        public string AddFactura(Factura fac) {
            string id = repository.Add(fac);
            return id;
        }


    }
}