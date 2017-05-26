using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;

namespace MailDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var mailSender = kernel.Get<IMailSender>();

            var formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}
