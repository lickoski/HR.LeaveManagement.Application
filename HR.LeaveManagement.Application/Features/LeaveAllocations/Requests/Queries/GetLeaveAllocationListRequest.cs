﻿using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    class GetLeaveAllocationListRequest: IRequest<List<LeaveAllocationDto>>
    {
    }
}
