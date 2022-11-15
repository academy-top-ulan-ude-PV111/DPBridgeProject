using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBridgeProject
{
    abstract internal class Programmer
    {
        public ILanguage Language { set; get; }

        public Programmer(ILanguage language)
        {
            Language = language;
        }

        public virtual void DoWork()
        {
            Language.Build();
            Language.Execute();
        }

        public abstract void Money();

    }

    class CompanyProgrammer : Programmer
    {
        public CompanyProgrammer(ILanguage language) : base(language) { }
        public override void Money()
        {
            Console.WriteLine("Зарплата в конце месяца");
        }
    }

    class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language) { }
        public override void Money()
        {
            Console.WriteLine("Зарплата по факту сдачи");
        }
    }
}
