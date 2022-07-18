using DevFreela.Core.DTOs;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Payments;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommandHandler : IRequestHandler<FinishProjectCommand, bool>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IPaymentService _paymentService;

        public FinishProjectCommandHandler(IProjectRepository projectRepository, IPaymentService paymentService)
        {
            _projectRepository = projectRepository;
            _paymentService = paymentService;
        }

        public async Task<bool> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            var paymentInfoDTO = new PaymentInfoDTO(request.Id, request.CreditCartNumber, request.Cvv, request.ExpiresAt, request.FullName);

            _paymentService.Process(paymentInfoDTO);
            
            project.PendingPayment();

            await _projectRepository.SaveChangesAsync();

            return true;
        }
    }
}
