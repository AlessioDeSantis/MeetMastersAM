namespace MeetMastersAM.Server.Repository
{
    public interface IRepositoryBase<T> where T : class
    {

        public Task<IEnumerable<T>> GetAll();
        public Task Create(T entity);
        public Task Update(T entity);
        public Task<T?> GetById(int id);
        public Task Delete(int id);

    }
}
