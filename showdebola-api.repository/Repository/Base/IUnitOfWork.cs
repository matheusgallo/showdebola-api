namespace showdebola_api.repository.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        ITeamRepository TeamRepository { get; }
    }
}