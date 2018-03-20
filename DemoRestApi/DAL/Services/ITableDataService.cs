namespace DemoRestApi.DAL.Services
{
    public interface ITableDataService
    {

        void Store<T>(T item) where T : new();
        T GetItem<T>(string key) where T : class;


    }
}