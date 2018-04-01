using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorDemos.Shared {
  public static class EnumUtil {
    public static IEnumerable<E> GetValues<E>() where E : struct
    {
      return Enum.GetValues(typeof(E)).Cast<E>();
    }
  }
}
