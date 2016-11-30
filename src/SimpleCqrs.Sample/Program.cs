using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCqrs.Commanding;
using SimpleCqrs.Eventing;
using SimpleCqrs.StructureMap;
using StructureMap;

namespace SimpleCqrs.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new Registry();
            registry.Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.AssembliesFromApplicationBaseDirectory();

                scanner.LookForRegistries();

                scanner.RegisterConcreteTypesAgainstTheFirstInterface();

                scanner.WithDefaultConventions();
            });
            var container = new Container(registry);

            StructureMapServiceLocator.SetTheContainer(container);

            var cqrs = container.GetInstance<CqrsRuntime>();
            cqrs.SetServiceLocator();
            cqrs.Start();

            Console.WriteLine("Started");
            var line = Console.ReadLine();
        }
    }

    public class SampleRegistry : Registry
    {
        public SampleRegistry()
        {
            For<ICommandBus>().Use<LocalCommandBus>().Singleton();
            For<IEventBus>().Use<LocalEventBus>().Singleton();
        }
    }

    public class CqrsRuntime : SimpleCqrsRuntime<StructureMapServiceLocator>
    {
        public void SetServiceLocator()
        {
            SimpleCqrs.ServiceLocator.SetCurrent(GetServiceLocator());
        }

        protected override IEventStore GetEventStore(IServiceLocator serviceLocator)
        {
            return serviceLocator.Resolve<IEventStore>();
        }

        protected override ISnapshotStore GetSnapshotStore(IServiceLocator serviceLocator)
        {
            return serviceLocator.Resolve<ISnapshotStore>();
        }

        protected override ICommandBus GetCommandBus(IServiceLocator serviceLocator)
        {
            return serviceLocator.Resolve<ICommandBus>();
        }

        protected override IEventBus GetEventBus(IServiceLocator serviceLocator)
        {
            return serviceLocator.Resolve<IEventBus>();
        }
    }

}
