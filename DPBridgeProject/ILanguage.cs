using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBridgeProject
{
    internal interface ILanguage
    {
        void Build();
        void Execute();
    }

    class JavaLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Компилятор Java создает байт-код");
        }

        public void Execute()
        {
            Console.WriteLine("На платформе VJM происходит JIT компиляция");
        }
    }

    class CppLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Компилятор CPP создает бинарный EXE файл");
        }

        public void Execute()
        {
            Console.WriteLine("Операционная система исполняет бинарный файл");
        }
    }
}
