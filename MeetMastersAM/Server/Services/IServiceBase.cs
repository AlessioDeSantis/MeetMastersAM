namespace MeetMastersAM.Server.Services
{
    public interface IServiceBase<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllElements();
        public Task CreateElement(T element);
        public Task UpdateElement(T element);
        public Task<T?> GetElementById(int id);
        public Task DeleteElement(int id);

    }
}
