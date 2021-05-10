using Microsoft.AspNetCore.Mvc;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace servPart.Managers.AuthenticationManager
{
    public class AccountManager
    {
        private AshanContext _con;
        public AccountManager(AshanContext con)
        {
            _con = con;
        }
        public ClaimsIdentity GetIdentity(string username, string password)
        {
            User person = _con.Users.FirstOrDefault(x => x.name == username && x.password == password);
            if (person != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.name),
                    //new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }
    }
}
