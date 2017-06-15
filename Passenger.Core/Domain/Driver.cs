using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Driver
    {
        public Driver()
        {
        }

        public Driver(Guid userId)
        {
            this.UserId = userId;
        }
       
        public Guid UserId { get; protected set; }
        
        public Guid Email { get; protected set; }
        
        public Vehicle Vehicle { get; protected set; }

        public IEnumerable<Route> Routes { get; protected set; }
        
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }
    }
}