using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.RenderTree;

namespace BlazorDemos.Client.Pages {
  public class Loading : BlazorComponent {
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
      builder.OpenElement(0, "div");
      builder.AddAttribute(1, "class", "loader");
      builder.CloseElement();
    }
  }
}
