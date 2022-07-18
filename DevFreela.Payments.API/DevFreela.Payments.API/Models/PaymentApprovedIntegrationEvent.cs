using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Payments.API.Models
{
    public class PaymentApprovedIntegrationEvent
    {
        public int IdProject { get; set; }

        public PaymentApprovedIntegrationEvent(int idProject)
        {
            IdProject = idProject;
        }
    }
}
