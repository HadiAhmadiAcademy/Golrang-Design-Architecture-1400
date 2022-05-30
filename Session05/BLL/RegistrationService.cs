using System;
using BLL.Contracts;

namespace BLL
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IUserStore _store;
        public RegistrationService(IUserStore store)
        {
            _store = store;
        }

        public void Register(UserDto dto)
        {
            _store.Add(dto);
        }
    }
}
