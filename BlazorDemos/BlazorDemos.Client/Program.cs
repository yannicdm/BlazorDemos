using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using BlazorDemos.Client.State;

namespace BlazorDemos.Client {
  public class Program {
    static void Main(string[] args)
    {
      var serviceProvider = new BrowserServiceProvider(configure => {
        // Add any custom services here
        configure.AddSingleton<Store>();
      });

      new BrowserRenderer(serviceProvider).AddComponent<App>("app");
    }
  }
}
