using Course.Config;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Util
{
    class NinjectRegistrations : NinjectModule
    {
        private IKernel _ninjectKernel;

        public NinjectRegistrations()
        {
            _ninjectKernel = new StandardKernel();
        }
        public override void Load()
        {
            new AuthContext();
            new LoggerContext();
            _ninjectKernel.Bind<DatabaseContext>().ToSelf();
        }

    }
}
