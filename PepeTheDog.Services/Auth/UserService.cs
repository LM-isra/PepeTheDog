using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PepeTheDog.Core;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Core.Dtos.Auth;

using PepeTheDog.Core.Services.Auth;
using AutoMapper;


namespace PepeTheDog.Services.Auth
{
    public class UserService : IAppUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AssignUserRole(UpdateRolUserDto rol)
        {
            await _unitOfWork.Users.AssignUserRole(rol);
        }

        public async Task RemoveUserRole(UpdateRolUserDto rol)
        {
            await _unitOfWork.Users.RemoveUserRole(rol);
        }
    }
}
