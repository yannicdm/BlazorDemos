using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Shared;

namespace BlazorDemos.Client.State {

  public class Store {
    public class UIModel {
      public bool ShowPizzaEditor { get; set; }

      public IEnumerable<Spicyness> SpicynessValues { get; }

      public Action UpdateUI { get; set; }

      public bool ShowLoading { get; set; }

      public UIModel()
      {
        SpicynessValues = Enum.GetValues(typeof(Spicyness))
                              .Cast<Spicyness>();
      }
    }

    public class PizzaModel {

      public string Owner { get; set; } = "Jefke";

      public IEnumerable<string> PizzaNames { get; set; } = new List<string> { "Loading" };

      public List<Pizza> Orders { get; set; } = new List<Pizza>();

      public Pizza Pizza { get; set; } 

      public void OrderPizza()
      {
        this.Orders.Add(this.Pizza);
        InitPizza();
      }

      public void InitPizza()
      {
        Pizza = new Pizza() { Name = PizzaNames.First(), Quantity = 1, Spicyness = Spicyness.Bland };
      }
    }

    public UIModel UI { get; set; } = new UIModel {
      ShowPizzaEditor = false
    };

    public PizzaModel PizzaPlace { get; set; } = new PizzaModel();

    public void StateHasChanged() => this.UI.UpdateUI();
  }
}
