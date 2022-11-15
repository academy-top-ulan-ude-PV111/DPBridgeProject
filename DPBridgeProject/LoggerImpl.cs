using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBridgeProject
{
    public interface ILoggerImpl
    {
        void ConsoleLog(string str);
        void FileLog(string str, string file);
        void SocketLog(string str, string domen, int port);
    }

    class SingleThreadImpl : ILoggerImpl
    {
        public void ConsoleLog(string str)
        {
            Console.WriteLine($"Single thread console -> [{str}]");
        }

        public void FileLog(string str, string file)
        {
            Console.WriteLine($"Single thread to file {file} -> [{str}]");
        }

        public void SocketLog(string str, string domen, int port)
        {
            Console.WriteLine($"Single thread to socket {domen}:{port} -> [{str}]");
        }
    }

    class MultiThreadImpl : ILoggerImpl
    {
        public void ConsoleLog(string str)
        {
            Console.WriteLine($"Multi thread console -> [{str}]");
        }

        public void FileLog(string str, string file)
        {
            Console.WriteLine($"Multi thread to file {file} -> [{str}]");
        }

        public void SocketLog(string str, string domen, int port)
        {
            Console.WriteLine($"Multi thread to socket {domen}:{port} -> [{str}]");
        }
    }
}
