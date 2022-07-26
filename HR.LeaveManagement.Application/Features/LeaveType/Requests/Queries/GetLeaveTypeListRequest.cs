using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace HR.LeaveManagement.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeListRequest: IRequest<List<LeaveTypeDto>>
    {
    }
}
