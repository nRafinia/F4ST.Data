﻿using Castle.Windsor;
using F4ST.Common.Containers;
using F4ST.Common.Mappers;

namespace F4ST.Data.LiteDB
{
    public class LiteDbInstaller : IIoCInstaller
    {
        public int Priority => -88;
        public void Install(WindsorContainer container, IMapper mapper)
        {

        }
    }
}