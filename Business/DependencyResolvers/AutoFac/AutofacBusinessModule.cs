using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();

            builder.RegisterType<EfCarDAL>().As<ICarDAL>().SingleInstance();
            builder.RegisterType<EfBrandDAL>().As<IBrandDAL>().SingleInstance();
            builder.RegisterType<EfColorDAL>().As<IColorDAL>().SingleInstance();
        }
    }
}
