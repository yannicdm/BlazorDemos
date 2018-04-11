using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace BlazorDemos.Client.Services {
  public interface IPizzaMenuService {
    Task<IEnumerable<string>> GetPizzaNames();
  }

  public class PizzaMenuService : IPizzaMenuService {
    private readonly HttpClient httpClient;

    public PizzaMenuService(HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    public async Task<IEnumerable<string>> GetPizzaNames()
    {
      return await this.httpClient.GetJsonAsync<string[]>("/menu");
    }
  }
}
