using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRestApi.Messages
{
    interface IMessageHelper
    {
        bool SendMessage(string Destination, object body);
    }
}
