using System.Collections.Generic;
using IdentityServer4.Test;
using System.Security.Claims;
using System;
using IdentityServer4.Models;
using IdentityServer4;
using ERP.API.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Dapper;
using ERP.Models;
using System.Linq;
using ERP.API.Models;

namespace ERP.API
{
    public static class Config
    {
        private static string GetNewGuid()
        {
            return new Guid().ToString();
        }
        public static List<TestUser> GetUsers()
        {

            string connString = Startup.StaticConfig.GetSection("Settings").GetValue<string>("DbConnectionString");
            MySqlConnection Connection = new MySqlConnection(connString);
            Connection.Open();
            var employees = Connection.Query<Employee>("select * from erp.employees;")
                                                .AsList<Employee>();
            var employeeFeatures = Connection.Query<EmployeeFeatures>("select * from erp.employee_features;")
                                                .AsList<EmployeeFeatures>();

            var result = employees.Where(e => !string.IsNullOrEmpty(e.Username) && e.IsActive).Select(u => new TestUser
            {
                SubjectId = Guid.NewGuid().ToString(),
                Username = u.Username,
                Password = u.Password
                                                                 ,
                Claims = new List<Claim>{
                                                                            new Claim("email",u.Email??""),
                                                                            new Claim("phone",u.MobileNo??""),
                                                                            new Claim("role",(u.Username=="nayef")?"admin":"user")
                                                                            ,new Claim("userid",u.Id.ToString())
                                                                            ,new Claim("features",string.Join(",",employeeFeatures.Where(f=>f.EmployeeId==u.Id).Select(f=>(int)f.FeatureId)))
                                                                            ,new Claim("name",u.Username)
                                                                        }
            }).ToList();
            Connection.Close();
            Connection.Dispose();
            return result;
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>{
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResources.Phone(),
            new IdentityResource("roles","Your Role(s)",new List<string>(){"role"})
            ,new IdentityResource("userids",new List<string>(){"userid"})
            ,new IdentityResource("featureset",new List<string>(){"features"})
            ,new IdentityResource("names",new List<string>(){"name"})
        };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>{
            new Client{
                ClientName              =   "BTH ERP WEB",
                ClientId                =   "bth.erp.web",
                AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                RedirectUris            =   new List<string>{"http://192.168.8.101:44344/signin-oidc"},
                PostLogoutRedirectUris  =   new List<string>{"http://192.168.8.101:44344/signout-callback-oidc"},
                AllowedScopes           =   {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                IdentityServerConstants.StandardScopes.Profile,
                                                IdentityServerConstants.StandardScopes.Email,
                                                "roles",
                                                "userids",
                                                "featureset",
                                                "names"
                                            },
                ClientSecrets           =   {new Secret("secret".Sha256())},
                    AllowOfflineAccess = true
            },
            new Client{
                ClientName              =   "BTH ERP WEB",
                ClientId                =   "bth.erp.web.localhost",
                AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                RedirectUris            =   new List<string>{"http://localhost:44333/signin-oidc"},
                PostLogoutRedirectUris  =   new List<string>{"http://localhost:44333/signout-callback-oidc"},
                AllowedScopes           =   {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                IdentityServerConstants.StandardScopes.Profile,
                                                IdentityServerConstants.StandardScopes.Email,
                                                "roles",
                                                "userids",
                                                "featureset",
                                                "names"
                                            },
                ClientSecrets           =   {new Secret("secret".Sha256())},
                    AllowOfflineAccess = true
            }
        };
        }
    }
}