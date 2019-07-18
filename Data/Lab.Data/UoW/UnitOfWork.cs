using Lab.Data.Context;
using Lab.Domain.Interfaces.UoW;

namespace Lab.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LabContext _labContext;
        public UnitOfWork(LabContext labContext)
        {
            _labContext = labContext;
        }
        public void Commit()
        {
            _labContext.SaveChanges();
        }
    }
}