using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Core.DTOs
{
    public class PaymentInfoDTO
    {
        public PaymentInfoDTO(int idProject, string creditCartNumber, string cvv, string expiresAt, string fullName)
        {
            IdProject = idProject;
            CreditCartNumber = creditCartNumber;
            Cvv = cvv;
            ExpiresAt = expiresAt;
            FullName = fullName;
        }

        public int IdProject { get; set; }
        public string CreditCartNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAt { get; set; }
        public string FullName { get; set; }
        public decimal Amount { get; set; }
    }
}
