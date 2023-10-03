using MeetMastersAM.Server.Repository;

namespace MeetMastersAM.Server.Services
{

    public class ServicesBase<T> : IServiceBase<T> where T : class
    {
        //Qui inniettiamo il repository
        private IRepositoryBase<T> _repository;
        //Questo è il costruttore
        public ServicesBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllElements()
        {
            return await _repository.GetAll();
        }

        public async Task CreateElement(T element)
        {
            await _repository.Create(element);
        }

        public async Task UpdateElement(T element)
        {
            await _repository.Update(element); 
        }

        public async Task<T?> GetElementById(int id)
        {
          return await _repository.GetById(id);
        }

        public async Task DeleteElement(int id)
        {
            await _repository.Delete(id);
        }





    }
}
