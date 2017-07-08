using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Route
    {
        public Guid Id { get; protected set; }
        public Node StartNode { get; protected set; }
        public Node EndNode { get; protected set; }

        protected Route()
        {
            this.Id = Guid.NewGuid();
        }

        protected Route(Node startnode, Node endnode)
        {
            this.StartNode = startnode;
            this.EndNode = endnode;
        }

        public static Route Create(Node startnode, Node endnode)
            => new Route(startnode, endnode);
    }
}