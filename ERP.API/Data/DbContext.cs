using Dapper;
using ERP.API.Models;
using ERP.Models.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ERP.API.Data
{
    public class QueryWithParameters{
        public string Query { get; set; }
        public DynamicParameters Parameters { get; set; }
        public bool IsProcedure { get; set; }
    }
    public interface IDbContext
    {
        T Execute<T>(string query);
        T Execute<T>(string query,DynamicParameters parameters);
        void ExecuteNonQuery(string query);
        void ExecuteNonQuery(string query,DynamicParameters parameters);

        void ExecuteTransaction(IEnumerable<QueryWithParameters> queries);
        void ExecuteMultipleQueries(IEnumerable<QueryWithParameters> queries);
        IEnumerable<T> GetList<T>(string query,DynamicParameters parameters);
        PagedList<T> GetListProcedure<T>(string query, DynamicParameters parameters);
        IEnumerable<T> GetList<T>(string query);
        T Get<T> (string query);
        T Get<T> (string query,DynamicParameters parameters);



    }
    public class DbContext :IDbContext
    {
        public MySqlConnection Connection{get;set;}

        private readonly IOptions<ConfigurationSettings> configuration;    
        
        public DbContext(IOptions<ConfigurationSettings> config)
        {
            configuration=config;
            Connection = new MySqlConnection(configuration.Value.DbConnectionString);
        }
        public T Execute<T>(string query)
        {
            try{            
                Connection.Open();
                var id=Connection.Query<T>(query).Single();
                Connection.Close();
                Connection.Dispose();
                return id;
            }
            catch{
                throw;
            }
        }

        

        public T Execute<T>(string query, DynamicParameters parameters)
        {
            try{            
                Connection.Open();
                var id=Connection.Query<T>(query,parameters).Single();
                Connection.Close();
                Connection.Dispose();
                return id;
            }
            catch{
                throw;
            }
        }

        public void ExecuteNonQuery(string query)
        {
            try{            
                Connection.Open();
                Connection.Execute(query);
                Connection.Close();
                Connection.Dispose();
            }
            catch{
                throw;
            }
        }

        

        public void ExecuteNonQuery(string query, DynamicParameters parameters)
        {
            try{            
                Connection.Open();
                Connection.Execute(query,parameters);
                Connection.Close();
                Connection.Dispose();
            }
            catch{
                throw;
            }
        }

        public void ExecuteTransaction(IEnumerable<QueryWithParameters> queries)
        {
            try{            
                Connection.Open();
                IDbTransaction transaction = Connection.BeginTransaction();
                try{
                    foreach(var query in queries){
                        int committedRows=0;
                        var commandType=query.IsProcedure?CommandType.StoredProcedure:CommandType.Text;


                        if(query.Parameters!=null){
                            committedRows=Connection.Execute(query.Query,query.Parameters,transaction:transaction,commandType:commandType);
                        }
                        else{
                            committedRows=Connection.Execute(query.Query,transaction:transaction,commandType:commandType);
                        }
                        if(committedRows==0){
                            transaction.Rollback();
                            throw new InvalidOperationException("Error updating Purchase Order Receiving!");
                        }
                    }                    
                    transaction.Commit();
                }
                catch{
                    transaction.Rollback();
                    throw;
                }
                finally{
                    Connection.Close();
                    Connection.Dispose();
                }
            }
            catch{
                throw;
            }
        }
        public void ExecuteMultipleQueries(IEnumerable<QueryWithParameters> queries)
        {
            try{            
                Connection.Open();
                try{
                    foreach(var query in queries){
                        int committedRows=0;
                        var commandType=query.IsProcedure?CommandType.StoredProcedure:CommandType.Text;


                        if(query.Parameters!=null){
                            committedRows=Connection.Execute(query.Query,query.Parameters,commandType:commandType);
                        }
                        else{
                            committedRows=Connection.Execute(query.Query,commandType:commandType);
                        }
                        
                    }
                }
                catch{
                    throw;
                }
                finally{
                    Connection.Close();
                    Connection.Dispose();
                }
            }
            catch{
                throw;
            }
        }
        public IEnumerable<T> GetList<T>(string query)
        {
            try{            
            Connection.Open();
            var id=Connection.Query<T>(query);
            Connection.Close();
            Connection.Dispose();
            return id;
            }
            catch{
                throw;
            }
        }

        public T Get<T> (string query)
        {
            try{            
            Connection.Open();
            var result=Connection.Query<T>(query);
            T entity=default(T);
            if(result.Count()>0)entity=result.Single();
            Connection.Close();
            Connection.Dispose();
            return entity;
            }
            catch{
                throw;
            }

        }

        public T Get<T>(string query, DynamicParameters parameters)
        {
            try{            
            Connection.Open();
            var result=Connection.Query<T>(query,parameters);
            T entity=default(T);
            if(result.Count()>0)entity=result.Single();
            Connection.Close();
            Connection.Dispose();
            return entity;
            }
            catch{
                throw;
            }
        }

        public IEnumerable<T> GetList<T>(string query, DynamicParameters parameters)
        {
            try{            
            Connection.Open();
            var id=Connection.Query<T>(query,parameters);
            Connection.Close();
            Connection.Dispose();
            return id;
            }
            catch{
                throw;
            }
        }

        public PagedList<T> GetListProcedure<T>(string query, DynamicParameters parameters)
        {
            try
            {
                Connection.Open();
                var result = new PagedList<T>();
                var pagedData=Connection.QueryMultiple(query, parameters, commandType: CommandType.StoredProcedure);
                result.Data = pagedData.Read<T>();
                result.Count = pagedData.Read<int>().FirstOrDefault();
                Connection.Close();
                Connection.Dispose();
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}