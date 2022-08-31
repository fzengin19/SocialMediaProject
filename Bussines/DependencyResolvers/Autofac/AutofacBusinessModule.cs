using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            builder.RegisterType<UserContactManager>().As<IUserContactService>();
            builder.RegisterType<EfUserContactDal>().As<IUserContactDal>();


            builder.RegisterType<EfPostDal>().As<IPostDal>();
            builder.RegisterType<PostManager>().As<IPostService>();


            builder.RegisterType<PrivateMessageManager>().As<IPrivateMessageService>();
            builder.RegisterType<EfPrivateMessageDal>().As<IPrivateMessageDal>();

            builder.RegisterType<UserDetailManager>().As<IUserDetailService>();
            builder.RegisterType<EfUserDetailDal>().As<IUserDeatilDal>();


            builder.RegisterType<UserDetailManager>().As<IUserDetailService>();
            builder.RegisterType<EfUserDetailDal>().As<IUserDeatilDal>();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
