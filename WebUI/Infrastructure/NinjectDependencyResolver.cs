using Domain.Abstract;
//using Domain.Concrete;
using Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            // kernel.Bind<IBookRepository>().To<EFBookRepository>();
            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(m => m.Books).Returns(new List<Book>
                {
                new Book { Name="Mova programs c# i platforma .Net 4.5", Author = "Troeslen e.t", Price = 1123},
                new Book { Name = "Mova programs c++ i platforma .Net 4.5", Author = "oeslen e.t", Price = 2323 },
                new Book { Name = "Mova programs c i platforma .Net 4.5", Author = "Troesn e.t", Price = 14523 },
            });
            kernel.Bind<IBookRepository>().ToConstant(mock.Object);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}