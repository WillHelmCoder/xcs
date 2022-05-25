using System.Collections.ObjectModel;
using xcs.Models;

namespace xcs.Services
{
    public class DataService
    {
        public ObservableCollection<PersonModel> Persons = new ObservableCollection<PersonModel>();

        public DataService()
        {


        Persons.Add(new PersonModel { Id = 1, Guid = Guid.NewGuid(), Email = "Will@gmail.com", LastName = "Espinola", FirstName = "Will", Talk = false }); ;
        Persons.Add(new PersonModel { Id = 2, Guid = Guid.NewGuid(), Email = "Will@gmail.com", LastName = "Preciado", FirstName = "Patty", Talk = true });
        Persons.Add(new PersonModel { Id = 3, Guid = Guid.NewGuid(), Email = "Will@gmail.com", LastName = "Albar", FirstName = "Andrea", Talk = false });
        Persons.Add(new PersonModel { Id = 4, Guid = Guid.NewGuid(), Email = "Will@gmail.com", LastName = "Gaspar", FirstName = "Daniela", Talk = false });
        Persons.Add(new PersonModel { Id = 5, Guid = Guid.NewGuid(), Email = "Will@gmail.com", LastName = "Navarro", FirstName = "Fernanda", Talk = false });
        
        //_repository = new Repository();
        //_repository.Create(new PersonModel { Id = 1, Guid = Guid.NewGuid().ToString(), Email = "Will@gmail.com", FullName = "Will ", LastName = "Espinola", FirstName = "Will", Coffee=1,XipeCoins=1});
        //_repository.Create(new PersonModel { Id = 1, Guid = Guid.NewGuid().ToString(), Email = "Will@gmail.com", FullName = "Will", LastName = "Lachica", FirstName = "Martin", Coffee=1,XipeCoins=1});
        //_repository.Create(new PersonModel { Id = 1, Guid = Guid.NewGuid().ToString(), Email = "Will@gmail.com", FullName = "Will", LastName = "Lopez", FirstName = "Ericka", Coffee=1,XipeCoins=1});

        //var listaFromSqlLite = _repository.List();
        //Persons = new ObservableCollection<PersonModel>();
        //foreach (var item in listaFromSqlLite)
        //{
        //    Persons.Add(item);
        //}

        }


    }
}
