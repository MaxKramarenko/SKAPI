using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using SKAPI.BL.Objects.Common;

[assembly: OwinStartup(typeof(SKAPI.Startup))]

namespace SKAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
