﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            //Bileşenlerin/hizmetlerin kayıtlı olduğu oluşturuyucu oluşturuyor.
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacBusinessModule());
            IContainer container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}