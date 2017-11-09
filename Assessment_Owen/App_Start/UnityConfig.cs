using Assesment_Owen_Repository;
using Assesment_Owen_Repository.Interfaces;
using Assessment_Owen_BusinessLogic;
using Assessment_Owen_BusinessLogic.Interfaces;
using System;

using Unity;

namespace Assessment_Owen
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
        public static IUnityContainer Container => container.Value;
        #endregion
        
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IEmployeeRepository, Employee>();
            container.RegisterType<IEmployeeOperation, EmployeeOperation>();
        }
    }
}