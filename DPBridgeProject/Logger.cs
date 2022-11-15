using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBridgeProject
{
    abstract internal class Logger
    {
        public ILoggerImpl? impl { set; get; }
        public Logger(ILoggerImpl? impl)
        {
            this.impl = impl;
        }
        abstract public void Log(string str);
    }

    class ConsoleLogger : Logger
    {
        public ConsoleLogger(ILoggerImpl impl) : base(impl) {}
        public override void Log(string str)
        {
            impl.ConsoleLog(str);
        }
    }

    class FileLogger : Logger
    {
        public string FileName { set; get; }
        public FileLogger(ILoggerImpl impl, string fileName) : base(impl) 
        { 
            this.FileName = fileName;
        }
        public override void Log(string str)
        {
            impl.FileLog(str, FileName);
        }
    }

    class SocketLogger : Logger
    {
        public string Domen { set; get; }
        public int Port { set; get; }

        public SocketLogger(ILoggerImpl impl, string domen, int port) : base(impl)
        {
            this.Domen = domen;
            this.Port = port;
        }
        public override void Log(string str)
        {
            impl.SocketLog(str, Domen, Port);
        }
    }
}
