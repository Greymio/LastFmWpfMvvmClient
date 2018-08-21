using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.MVVM
{
    public static class Mediator<TSender>
    {
        private static Action<TSender, string> _broadcast;

        public static void Register(Action<TSender, string> method)
        {
            _broadcast += method;
        }

        public static void Unregister(Action<TSender, string> method)
        {
            _broadcast -= method;
        }

        public static void Send(TSender sender, string info)
        {
            _broadcast?.Invoke(sender, info);
        }
    }
}
