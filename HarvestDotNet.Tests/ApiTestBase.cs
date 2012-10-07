﻿using System;
using HarvestDotNet.Tests.TestSupport;
using NUnit.Framework;

namespace HarvestDotNet.Tests
{
  public class ApiTestBase
  {
    protected TestHttpServer HttpServer;
    [SetUp]
    public void Setup()
    {
      HttpServer = new TestHttpServer();
    }

    [TearDown]
    public void TearDown()
    {
      if (HttpServer != null)
        HttpServer.Dispose();
    }

    protected HarvestApi GetStandardApi()
    {
      var settings = new HarvestApiSettings()
                       {
                         BaseUri = HttpServer.BaseUri,
                         Password = "password",
                         UserName = "username",
                       };
      var api = new HarvestApi(settings);
      return api;
    }
  }
}
