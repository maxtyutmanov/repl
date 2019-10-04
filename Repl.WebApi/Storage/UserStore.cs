using Repl.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repl.WebApi.Storage
{
    public class UserStore
    {
        private readonly WriteRedirect<User> _writeRedirect;

        public UserStore(WriteRedirect<User> writeRedirect)
        {
            _writeRedirect = writeRedirect;
        }

        public List<string> GetAllIds()
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(User user)
        {
            _writeRedirect.AddOrUpdate(user);
        }

        public void DeleteIfExists(string userId)
        {
            _writeRedirect.DeleteIfExists(userId);
        }
    }
}
