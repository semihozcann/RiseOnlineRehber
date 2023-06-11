using Autofac;
using Microsoft.EntityFrameworkCore;
using RiseOnlineRehber.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseOnlineRehber.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<RiseOnlieRehberContext>().As<DbContext>().SingleInstance();





        }
    }
}
