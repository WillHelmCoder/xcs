using SQLite;
using xcs.Models;
namespace xcs.Services;

internal class Repository
{
    private readonly SQLiteConnection _database;
    public Repository()
    {
       var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "entities.db");
       _database = new SQLiteConnection(dbPath);
       _database.CreateTable<PersonModel>();
    }
    public List<PersonModel> List()
    {
        return _database.Table<PersonModel>().ToList();
    }
    public int Create(PersonModel entity)
    {       
        //var get = _database.Find<PersonModel>(entity);
        //if (get != null)  return get.Id;        
        return _database.Insert(entity);
    }
    public int Update(PersonModel entity)
    {
        return _database.Update(entity);
    }
    public int Delete(PersonModel entity)
    {
        return _database.Delete(entity);
    }
}
