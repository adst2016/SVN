using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace CastleLibrary
{
    public interface IDependency1
    {
        object SomeObject { get; set; }
    }

    public class Dependency1 : IDependency1
    {
        public object SomeObject { get; set; }
    }

    public interface IDependency2
    {
        object SomeOtherObject { get; set; }
    }

    public class Dependency2 : IDependency2
    {
        public object SomeOtherObject { get; set; }
    }

    public class Main
    {
        private IDependency1 object1;
        private IDependency2 object2;

        public Main(IDependency1 dependency1, IDependency2 dependency2)
        {
            object1 = dependency1;
            object2 = dependency2;
        }

        public void DoSomething()
        {
            object1.SomeObject = "Hello world!";
            object2.SomeOtherObject = "Hello mars!";
        }

    }

    public class InversionOfControl
    {
        public void ExecuteIoc()
        {
            var container = new WindsorContainer();

            container.Register(Castle.MicroKernel.Registration.Component.For<Main>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDependency1>().ImplementedBy<Dependency1>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IDependency2>().ImplementedBy<Dependency2>());


            var mainThing = container.Resolve<Main>();
            mainThing.DoSomething();
        }
    }
}
