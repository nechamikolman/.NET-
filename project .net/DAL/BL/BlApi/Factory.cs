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
    public static IBl Get
    {
        get
        {
            string blType = s_dalName ?? throw new DalConfigException($"DAL name is not extracted from the configuration");
            string bl = s_dalPackages[blType] ?? throw new DalConfigException($"Package for {blType} is not found in packages list in dal-config.xml");

            try { Assembly.Load(bl ?? throw new DalConfigException($"Package {bl} is null")); }
            catch (Exception ex) { throw new DalConfigException($"Failed to load {bl}.dll package", ex); }

            Type type = Type.GetType($"Dal.{bl}, {bl}") ??
                throw new DalConfigException($"Class Dal.{bl} was not found in {bl}.dll");

            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IBl ??
                throw new DalConfigException($"Class {bl} is not a singleton or wrong property name for Instance");
        }
    }
}
