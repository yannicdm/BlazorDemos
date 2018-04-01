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

      public UIModel()
      {
        SpicynessValues = Enum.GetValues(typeof(Spicyness))
                              .Cast<Spicyness>();
      }
    }

    public class PizzaModel {

      public string Owner { get; set; } = "Jefke";

      public Pizza Pizza { get; set; } = new Pizza();
    }

    public UIModel UI { get; set; } = new UIModel {
      ShowPizzaEditor = false
    };

    public PizzaModel PizzaPlace { get; set; } = new PizzaModel();

    public void StateHasChanged() => this.UI.UpdateUI();
  }
}
