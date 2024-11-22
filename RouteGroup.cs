using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class RouteGroup : RouteComponent
    {
        private List<RouteComponent> children = new List<RouteComponent>();

        public override void Add(RouteComponent component)
        {
            children.Add(component);
        }

        public override void Remove(RouteComponent component)
        {
            children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override List<RouteComponent> Operation()
        {
            return children;
        }
    }
}
