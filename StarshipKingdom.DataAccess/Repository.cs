using System.Data.SqlClient;
using System.Linq;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Services;
using Dapper;

namespace StarshipKingdom.DataAccess
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : BaseModel
    {
        private readonly IApplicationSettingsReader _reader;

        public string ConnectionString { get; set; }

        public string TableName { get; set; }

        protected Repository(IApplicationSettingsReader reader)
        {
            _reader = reader;

            ConnectionString = _reader.GetConnectionString();

            TableName = string.Format("[dbo].[{0}s]", typeof (TModel).Name);
        }

        public TModel Get(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var query = string.Format("select * from {0} where Id = @Id", TableName);

                var result = connection.Query<TModel>(query, new { Id = id });

                return result.FirstOrDefault();
            }
        }

        public abstract int Insert(TModel model);

        public abstract void Update(TModel model);

        public void Delete(TModel model)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var query = string.Format("delete from {0} where Id = @Id", TableName);

                connection.Query<TModel>(query, new { Id = model });
            }
        }
    }
}
