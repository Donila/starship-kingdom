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

        public abstract TModel Get(int id);

        public abstract int Insert(TModel model);

        public abstract void Update(TModel model);

        public abstract void Delete(TModel model);
    }
}
