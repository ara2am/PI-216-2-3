using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Services
{
    public class ActionResult
    {
        public ActionResult (bool state, string message)
        {
            State = state;
            Message = message;
        }
        public bool State { get; private set; }
        public string Message { get; private set; }
    }
}
