using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Core.Services
{
    public interface IMessageBusService
    {
        void Publish(string queue, byte[] message);
    }
}
