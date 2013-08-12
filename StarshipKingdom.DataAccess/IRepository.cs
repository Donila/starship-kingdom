using StarshipKingdom.Domain.Models;

namespace StarshipKingdom.DataAccess
{
    public interface IRepository<TModel> where TModel : BaseModel
    {
        TModel Get(int id);

        int Insert(TModel model);

        void Update(TModel model);

        void Delete(TModel model);
    }
}
