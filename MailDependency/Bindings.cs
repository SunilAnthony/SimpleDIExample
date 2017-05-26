using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject;

namespace MailDependency 
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MockMailSender>();
            //Bind<IMailSender>().To<MailSender>();
        }
    }
}
