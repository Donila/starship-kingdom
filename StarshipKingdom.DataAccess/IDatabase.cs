namespace StarshipKingdom.DataAccess
{
    public interface IDatabase
    {
        bool IsExist(string databaseName);

        void Create(string databaseName);

        void Update(string databaseName);

        void Delete(string databaseName);
    }
}
