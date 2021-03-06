//-----------------------------------------------------------------------
// <copyright file="ApplicationContextManager.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Application context manager that uses HttpContextAccessor</summary>
//-----------------------------------------------------------------------
#if !BLAZOR
using Csla.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Csla.AspNetCore
{
  /// <summary>
  /// Application context manager that uses HttpContextAccessor when 
  /// resolving HttpContext to store context values.
  /// </summary>
  public class ApplicationContextManager : IContextManager
  {

    private const string _localContextName = "Csla.LocalContext";
    private const string _clientContextName = "Csla.ClientContext";
    private const string _globalContextName = "Csla.GlobalContext";

    private readonly IServiceProvider _serviceProvider;

    /// <summary>
    /// Creates an instance of the object, initializing it
    /// with the required IServiceProvider.
    /// </summary>
    /// <param name="serviceProvider">ASP.NET Core IServiceProvider</param>
    public ApplicationContextManager(IServiceProvider serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Gets the current HttpContext instance.
    /// </summary>
    protected virtual HttpContext HttpContext
    {
      get
      {
        HttpContext result = null;
        if (_serviceProvider != null)
        {
          var httpContextAccessor = (IHttpContextAccessor)_serviceProvider.GetService(typeof(IHttpContextAccessor));
          if (httpContextAccessor != null)
          {
            result = httpContextAccessor.HttpContext;
          }
        }
        return result;
      }
    }

    /// <summary>
    /// Gets a value indicating whether this
    /// context manager is valid for use in
    /// the current environment.
    /// </summary>
    public bool IsValid
    {
      get { return HttpContext != null; }
    }

    /// <summary>
    /// Gets the current principal.
    /// </summary>
    public System.Security.Principal.IPrincipal GetUser()
    {
      var result = HttpContext?.User;
      if (result == null)
      {
        result = new Csla.Security.CslaClaimsPrincipal();
        SetUser(result);
      }
      return result;
    }

    /// <summary>
    /// Sets the current principal.
    /// </summary>
    /// <param name="principal">Principal object.</param>
    public void SetUser(System.Security.Principal.IPrincipal principal)
    {
      HttpContext.User = (ClaimsPrincipal)principal;
    }

    /// <summary>
    /// Gets the local context.
    /// </summary>
    public ContextDictionary GetLocalContext()
    {
      return (ContextDictionary)HttpContext?.Items[_localContextName];
    }

    /// <summary>
    /// Sets the local context.
    /// </summary>
    /// <param name="localContext">Local context.</param>
    public void SetLocalContext(ContextDictionary localContext)
    {
      HttpContext.Items[_localContextName] = localContext;
    }

    /// <summary>
    /// Gets the client context.
    /// </summary>
    public ContextDictionary GetClientContext()
    {
      return (ContextDictionary)HttpContext?.Items[_clientContextName];
    }

    /// <summary>
    /// Sets the client context.
    /// </summary>
    /// <param name="clientContext">Client context.</param>
    public void SetClientContext(ContextDictionary clientContext)
    {
      HttpContext.Items[_clientContextName] = clientContext;
    }

    /// <summary>
    /// Gets the global context.
    /// </summary>
    public ContextDictionary GetGlobalContext()
    {
      return (ContextDictionary)HttpContext?.Items[_globalContextName];
    }

    /// <summary>
    /// Sets the global context.
    /// </summary>
    /// <param name="globalContext">Global context.</param>
    public void SetGlobalContext(ContextDictionary globalContext)
    {
      HttpContext.Items[_globalContextName] = globalContext;
    }

    /// <summary>
    /// Gets the default IServiceProvider
    /// </summary>
    public IServiceProvider GetDefaultServiceProvider()
    {
      return HttpContext?.RequestServices;
    }

    /// <summary>
    /// Sets the default IServiceProvider
    /// </summary>
    /// <param name="serviceProvider">IServiceProvider instance</param>
    public void SetDefaultServiceProvider(IServiceProvider serviceProvider)
    {
      /* ignore value - we get the one from HttpContext */
    }

    /// <summary>
    /// Gets the scoped IServiceProvider
    /// </summary>
    public IServiceProvider GetScopedServiceProvider()
    {
      IServiceProvider result;
      result = (IServiceProvider)Csla.ApplicationContext.LocalContext["__ssp"];
      if (result == null)
        result = GetDefaultServiceProvider();
      return result;
    }

    /// <summary>
    /// Sets the scoped IServiceProvider
    /// </summary>
    /// <param name="serviceProvider">IServiceProvider instance</param>
    public void SetScopedServiceProvider(IServiceProvider serviceProvider)
    {
      Csla.ApplicationContext.LocalContext["__ssp"] = serviceProvider;
    }
  }
}
#endif