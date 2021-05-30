using Course.Config;
using Ninject;
using Ninject.Modules;

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
