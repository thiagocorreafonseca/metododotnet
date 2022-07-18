using MediatR;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommand : IRequest<bool>
    {
        public FinishProjectCommand(int id, string creditCartNumber, string cvv, string expiresAt, string fullName)
        {
            Id = id;
            CreditCartNumber = creditCartNumber;
            Cvv = cvv;
            ExpiresAt = expiresAt;
            FullName = fullName;
        }

        public int Id { get; private set; }
        public string CreditCartNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAt { get; set; }
        public string FullName { get; set; }
    }
}
