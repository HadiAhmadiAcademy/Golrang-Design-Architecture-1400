using System;
using Autofac;
using BLL;
using BLL.Contracts;
using DAL;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<RegistrationService>().As<IRegistrationService>();
            builder.RegisterType<SqlUserStore>().As<IUserStore>();
            builder.RegisterType<SqlConnection>().As<IDatabaseConnection>();
            var container = builder.Build();
            
            //---------------------------------------

            var registrationService = container.Resolve<IRegistrationService>();
        }
    }
}
