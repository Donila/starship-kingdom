using System;
using System.Data.SqlClient;
using System.Linq;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Services;

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
        }

        public TModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public abstract int Insert(TModel model);

        public abstract void Update(TModel model);

        public void Delete(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
