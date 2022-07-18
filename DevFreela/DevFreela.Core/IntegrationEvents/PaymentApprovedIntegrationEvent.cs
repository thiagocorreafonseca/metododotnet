using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Core.IntegrationEvents
{
    public class PaymentApprovedIntegrationEvent
    {
        public PaymentApprovedIntegrationEvent(int idProject)
        {
            IdProject = idProject;
        }
        public int IdProject { get; set; }
    }
}
