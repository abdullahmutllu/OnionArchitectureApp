using MediatR;

namespace OnionApp.Application.Features.Companies.Commands.CreateCompany
{
    public record CreateCompanyCommand(string CompanyName,int OrderStartTimeHour,int OrderStartTimeMinute,int OrderFinishTimeHour, int OrderFinishTimeMinute) : IRequest<CreateCompanyCommandResponse>
    {
    }
}
