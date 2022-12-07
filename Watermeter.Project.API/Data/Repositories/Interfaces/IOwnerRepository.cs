﻿
using System.Net;
using Watermeter.Project.API.Models;

namespace Watermeter.Project.API.Data.Repositories.Interfaces
{
    public interface IOwnerRepository
    {
        Task Save(Owner owner);
        Task<Owner> GetSingle(int id);
        Task<List<Owner>> GetList();
        Task<bool> Delete(int id);
        Task<bool> Update(Owner model);
        Task<bool> ValidateCredentials(Credentials credentials);
    }
}
