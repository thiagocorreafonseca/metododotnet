using DevFreela.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Payments
{
    public interface IPaymentService
    {
        void Process(PaymentInfoDTO paymentInfoDTO);
    }
}
