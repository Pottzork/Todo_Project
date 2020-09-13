using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
   public class AddressRepository: IAddressRepository
    {
        private readonly string _connectionString;

        public AddressRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public async Task<bool> AddAddress(Addresss address)
        {
            
                using (var c = new SqlConnection(_connectionString))
                {
                    try
                    {
                    await c.ExecuteAsync("INSERT INTO Addresss (Street, City, PostalCode, Country) VALUES (@Street, @City, @PostalCode, @Country)",
                        new { address.Street, address.City, address.PostalCode, address.Country});
                    return true;
                }
                    catch (Exception)
                    {

                        return false;
                    }
                }
            
        }

        public async Task<bool> DeleteAddress(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("DELETE from Addresss WHERE AddressId = @id", new { id });
                        return true;
                }
                catch (Exception)
                {

                    return false ;
                }
            }
        }

        public async Task<Addresss> GetAddress(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                   return await c.QueryFirstOrDefaultAsync("SELECT * FROM Addresss WHERE AddressId  = @id", new { id });
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task<IEnumerable<Addresss>> GetAddresses()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<Addresss>("SELECT * FROM Addresss");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public async Task<bool> UpdateAddress(Addresss address)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("UPDATE Addresss SET Street = @Street, City = @City, PostalCode = @PostalCode, Country = @Country WHERE AddressId = @AddressId",
                        new { address.Street, address.City, address.PostalCode, address.Country, address.AddressId });

                    return true;
                }
                catch (Exception)
                {
                    return false;                    ;
                }
            }
        }
    }
}
