using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;
using static BlApi.BlConfig;
using System.Reflection;
public static class Factory
{
    public static IBl Get => new BlImplementation.Bl();
}
