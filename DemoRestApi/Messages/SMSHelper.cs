using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRestApi.Messages
{
    public class SMSHelper : IMessageHelper
    {
        public bool SendMessage(string Destination, object body)
        {
            bool result = false;
            Console.WriteLine("Sending SMS" + result);
            return result;
        }
    }
}