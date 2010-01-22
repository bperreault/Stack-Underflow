﻿#region

using Castle.Windsor;
using NHibernate;
using NUnit.Framework;
using StackUnderflow.Bootstrap;
using StackUnderflow.Tests.Persistence;

#endregion

namespace StackUnderflow.Tests
{
    public abstract class IntegrationTestBase
    {
        public WindsorContainer Container { get; set; }

        [TestFixtureSetUp]
        public virtual void FixtureSetup()
        {
            Container = Bootstrapper.Instance.CreateContainer(typeof(IntegrationTestBase).Assembly);
        
            FixtureSetupCore();
        }

        [SetUp]
        public virtual void Setup()
        {
            DBUtils.ClearDatabase(Container.Resolve<ISessionFactory>());
            SetupCore();
        }

        public virtual void FixtureSetupCore()
        {
        }

        public virtual void SetupCore()
        {
        }

        protected T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}