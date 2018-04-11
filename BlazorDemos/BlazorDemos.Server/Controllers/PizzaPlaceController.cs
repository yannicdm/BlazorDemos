using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemos.Server.Controllers {
  public class PizzaPlaceController : Controller {

    private static readonly IEnumerable<string> pizzaNames = new List<string> {
      "Pepperoni",
      "Quattro Frommagi"
    };

    [HttpGet("/menu")]
    public async Task<IEnumerable<string>> PizzaNames()
    {
      await Task.Delay(millisecondsDelay: 2000);
      return pizzaNames;
    }
  }
}