using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRestApi.Messages
{
    public class EmailHelper : IMessageHelper
    {
        public bool SendMessage(string Destination, object body)
        {
            bool result = false;
            Console.WriteLine("Sending Email" + result);
            return result;
        }
    }
}