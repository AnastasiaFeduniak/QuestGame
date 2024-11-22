using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Routes : RouteComponent
    {
        private List<Replics> replics = new List<Replics>();
        public Routes(List<Replics> replics)
        {
            this.replics = replics;
        }
        public List<Replics> getReplics()
        {
            return replics;
        }

        public void setReplics(List<Replics> replics)
        {
            this.replics = replics;
        }

        public void Add(Replics rep)
        {

        }
        public override void Remove(RouteComponent component)
        {

        }
        public override bool IsComposite()
        {
            return false;
        }

        public override void Add(RouteComponent component)
        {
            throw new NotImplementedException();
        }

        public override List<RouteComponent> Operation()
        {
            throw new NotImplementedException();
        }
    }
}
