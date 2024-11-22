using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class RouteComponent
    {
        public abstract void Add(RouteComponent component);
        public abstract void Remove(RouteComponent component);
        public abstract bool IsComposite();
        public abstract List<RouteComponent> Operation();
    }
}
