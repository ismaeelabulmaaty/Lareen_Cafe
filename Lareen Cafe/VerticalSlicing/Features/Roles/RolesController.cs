using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.AssignRoleToUser;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.CreateRole.CreateNewRole;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.CreateRole;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRole;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRoleFromUser;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetAllRoles;
using LareenCafe.Api.VerticalSlicing.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.AssignRoleToUser.AssignRoleToUserCom;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRoleFromUser.RemoveRoleFromUserCom;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles
{
    public class RolesController : BaseController
    {
        public RolesController(ControllerParameters controllerParameters) : base(controllerParameters) { }


        [HttpPost("Add New Role")]
        public async Task<Result<bool>> AddRoleToUser(AddRoleRequest request)
        {
            var command = request.Map<CreateRoleCommand>();
            var response = await _mediator.Send(command);
            return response;
        }

        [HttpPost("Assign Role To User")]
        public async Task<Result<bool>> AssignRoleToUser(AssignRoleToUserRequest request)
        {
            var command = request.Map<AssignUserToRoleCommand>();
            var response = await _mediator.Send(command);
            return response;
        }

        [HttpDelete("Remove Role From User({UserRoleId})")]
        public async Task<Result<bool>> RemoveRoleFromUser(int UserRoleId )
        {
            //var command = request.Map<RemoveRoleFromUserCommand>();
            var response = await _mediator.Send(new RemoveRoleFromUserCommand(UserRoleId));
            return response;
        }

        [HttpDelete("Remove Role By Id/{roleId}")]
        public async Task<Result<bool>> RemoveRole(int roleId)
        {
            var response = await _mediator.Send(new RemoveRoleCommand(roleId));
            return response;
        }

        [HttpGet("Get All Roles")]
        public async Task<Result<List<Role>>> GetAllRoles()
        {
            var response = await _mediator.Send(new GetAllRolesQuery());
            return response;
        }

    }
}
