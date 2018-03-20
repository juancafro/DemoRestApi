using DemoRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRestApi.DAL
{
    public interface IDataRepository
    {
        Factura Get(string Id);
        string Add(Factura Fac);
    }
}
