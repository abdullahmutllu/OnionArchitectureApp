using MediatR;

namespace OnionApp.Application.Features.Companies.Commands.UpdateCompany
{
    public record UpdateCompanyCommand(
        string CompanyId,
        int OrderStartTimeHour, int OrderStartTimeMinute
        ) : IRequest<UpdateCompanyCommandResponse>;

}
