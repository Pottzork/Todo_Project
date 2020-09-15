using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OperatorRepository : IOperatorRepository
    {
        private readonly string _connectionString;

        public OperatorRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        //Adding a Operator using incoming Operator
        #region AddOperator(Operators Operator)
        public async Task<bool> AddOperator(Operators Operator)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("INSERT INTO Operators (UserName, Password, FirstName, LastName, Email, Phone, Location) VALUES (@UserName, @Password, @FirstName, @LastName, @Email, @Phone, @Location",
                        new { Operator.UserName, Operator.Password, Operator.FirstName, Operator.LastName, Operator.Email, Operator.Phone, Operator.Location });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        //Deleting one Operator by id
        #region DeleteOperator(int id)
        public async Task<bool> DeleteOperator(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("DELETE FROM Operators WHERE OpId = @id", new { id });
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        //Getting all Operators
        #region GetAllOperators()
        public async Task<IEnumerable<Operators>> GetAllOperators()
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryAsync<Operators>("SELECT * FROM Operators");  
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        #endregion

        //Getting one Operator by id
        #region GetOperator(int id)
        public async Task<Operators> GetOperator(int id)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    return await c.QueryFirstOrDefaultAsync<Operators>("SELECT * FROM Operators WHERE OpId = @Id", new { id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion

        //Update Operator using incoming Operator object
        #region UpdateOperator(Operators Operator)
        public async Task<bool> UpdateOperator(Operators Operator)
        {
            using (var c = new SqlConnection(_connectionString))
            {
                try
                {
                    await c.ExecuteAsync("UPDATE Operators SET UserName = @UserName, Password = @Password, FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Location = @Location",
                        new { Operator.UserName, Operator.Password, Operator.FirstName, Operator.LastName, Operator.Email, Operator.Phone, Operator.Location, Operator.OpId });

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion
    }
}
