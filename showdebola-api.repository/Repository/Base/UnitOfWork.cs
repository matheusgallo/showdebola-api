using System;

namespace showdebola_api.repository.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBContext _dbcontext;

        private ITeamRepository _teamRepository;

        public ITeamRepository TeamRepository => GetInstance<ITeamRepository, TeamRepository>(ref _teamRepository, _dbcontext);

        public UnitOfWork(IDBContext dbcontext) => _dbcontext = dbcontext;

        public void Dispose() => _dbcontext.Dispose();

        private static T GetInstance<T, U>(ref T repository, IDBContext dbcontext)
        {
            if (repository == null)
                repository = (T)Activator.CreateInstance(typeof(U), dbcontext);

            return repository;
        }
    }
}
