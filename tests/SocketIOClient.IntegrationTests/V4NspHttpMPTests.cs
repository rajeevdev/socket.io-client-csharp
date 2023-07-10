﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocketIO.Core;

namespace SocketIOClient.IntegrationTests
{
    [TestClass]
    public class V4NspHttpMPTests : HttpMPBaseTests
    {
        protected override string ServerUrl => Common.Startup.V4_NSP_HTTP_MP;
        protected override EngineIO EIO => EngineIO.V4;
        protected override string ServerTokenUrl => Common.Startup.V4_NSP_HTTP_TOKEN_MP;
    }
}