using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Web;
using System.Web.Http.Dependencies;

namespace Hospital.Web.Base
{
    public class MefDependencySolver : IDependencyResolver, System.Web.Mvc.IDependencyResolver
    {
        private readonly ComposablePartCatalog _catalog;
        private const string MefContainerKey = "MefContainerKey";

        public MefDependencySolver(ComposablePartCatalog catalog)
        {
            _catalog = catalog;
        }

        public CompositionContainer Container
        {
            get
            {
                if (!HttpContext.Current.Items.Contains(MefContainerKey))
                {
                    HttpContext.Current.Items.Add(MefContainerKey, new CompositionContainer(_catalog, CompositionOptions.DisableSilentRejection));
                }
                var container = (CompositionContainer)HttpContext.Current.Items[MefContainerKey];
                HttpContext.Current.Application["Container"] = container;
                HttpContext.Current.DisposeOnPipelineCompleted(container);
                return container;
            }
        }

        #region IDependencyResolver Members

        public object GetService(Type serviceType)
        {
            var contractName = AttributedModelServices.GetContractName(serviceType);
            return Container.GetExportedValueOrDefault<object>(contractName);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.GetExportedValues<object>(serviceType.FullName);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
        /// <summary>
        /// 释放内存资源
        /// </summary>
        public void Dispose()
        {
            //调用带参数的Dispose方法，释放托管和非托管资源
            Dispose(true);
            //手动调用了Dispose释放资源，那么析构函数就是不必要的了，这里阻止GC调用析构函数
            GC.SuppressFinalize(this);

        }

        /// <summary>
        /// protected的Dispose方法，保证不会被外部调用。
        /// 传入bool值disposing以确定是否释放托管资源
        /// </summary>
        /// <param name="disposing">是否释放资源</param>
        private void Dispose(bool disposing)
        {
            if (!disposing) return;
            Container.Dispose();
        }

        #endregion

    }
}