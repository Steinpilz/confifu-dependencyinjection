using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Confifu.Abstractions.DependencyInjection
{

    public class ServiceCollection : List<ServiceDescriptor>, IServiceCollection
    {
        public ServiceCollection() : base() { }

        public ServiceCollection(IEnumerable<ServiceDescriptor> collection) : base(collection)
        {
        }

        public ServiceCollection(int capacity) : base(capacity)
        {
        }
    }
}