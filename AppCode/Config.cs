
using System.Collections.Generic;
using IdentityServer4.EntityFramework.Entities;

namespace IdentityServer4.Demo.AppCode
{
   public class Config
   {
       public static IEnumerable<ApiResource> GetApiResources()
       {
           return new List<ApiResource>
           {
               new ApiResource("api1", "My API")
           };
       }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> 
            {
                new Client
                {    
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantType.CleintCredentials,

                    // secret for authentication
                    ClientSecrets = 
                    {
                        new Secret("secret".Sha256())
                    },
                    // scopes that client has access to
                    AllowedScope = {"api1"}
                }
            };
        }
   } 
}