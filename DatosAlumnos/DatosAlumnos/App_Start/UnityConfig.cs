using DatosAlumnos.Data;
using DatosAlumnos.Repositories;
using System;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace DatosAlumnos
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        /// 


        public static IUnityContainer Container => container.Value;
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
        }
        public static void RegisterDependencies()
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IContextoEscuela, ContextoEscuelaMySql>();             //INDICAMOS QUE CONTEXTO VAMOS A USAR DE LA CLASE CONTEXT
            container.RegisterType<IRepositoryEscuela, RepositoryEscuela>();            //INDICAMOS QUE CLASE USARA CUANDO DETECTE EL IRepository
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));     //INDICAMOS AL ENTORNO MVC QUE CONTENEDOR IoC VA A UTILIZAR
        }

    }
}