using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClass
{
    
    class Implement
    {
        private Services services;
        public Implement(Services service)
        {
            services = service;
        }
        public void show()
        {
            services.Say();
        }
    }
}
