using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ClientAccess
    {
        public static Client getClient(Guid Id)
        {
            try
            {
                using (var ctx = new ApiDBContext())
                {
                    return ctx.Clients.FirstOrDefault(c=>c.Id.Equals(Id));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Client getClientByEmail(string email)
        {
            try
            {
                using (var ctx = new ApiDBContext())
                {
                    return ctx.Clients.FirstOrDefault(c => c.Email.Equals(email));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Client> GetClients()
        {
            try
            {
                using (var ctx = new ApiDBContext())
                {
                    return ctx.Clients.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SaveClient(Client cl)
        {
            try
            {
                using (var ctx = new ApiDBContext())
                {
                    ctx.Clients.Add(cl);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void UpdateClient(Client cl)
        {
            try
            {
                using (var ctx = new ApiDBContext())
                {

                    var originalClient = ctx.Clients.Single(c => c.Id.Equals(cl.Id));

                    originalClient.FirstName = cl.FirstName;
                    originalClient.LastName = cl.LastName;
                    originalClient.Born = cl.Born;
                    originalClient.Address = cl.Address;
                    originalClient.Phone = cl.Phone;
                    originalClient.City = cl.City;
                    originalClient.Country = ctx.Country.FirstOrDefault(c => c.Id.Equals(cl.Country.Id));

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DisableClient(Client cl)
        {
            try
            {
                using (var ctx = new ApiDBContext())
                {

                    var originalClient = ctx.Clients.Single(c => c.Id.Equals(cl.Id));
                    originalClient.IsActive = false;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
