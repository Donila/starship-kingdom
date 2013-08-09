namespace StarshipKingdom.DataAccess
{
    public interface IRepository<TModel> where TModel : class
    {
        TModel Get(int id);

        int Insert(TModel model);

        void Update(TModel model);

        void Delete(TModel model);
    }
}
