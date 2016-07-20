using Microsoft.Practices.Unity;
using School.Data.Data.Repositories;

namespace School.Business.Bootstrapper
{
    public static class UnityLoader
    {
        public static IUnityContainer Init()
        {
            var container = new UnityContainer();

            var assembly = typeof(AlunoRepository).Assembly;

            container.RegisterTypes
            (
                AllClasses.FromAssemblies(assembly),
                WithMappings.FromMatchingInterface
            );

            return container;
        }
    }
}