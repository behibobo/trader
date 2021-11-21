using System;
using TraderPanel.Core.Repositories.Interfaces;

namespace TraderPanel.Core.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        public RepositoryWrapper(IPlanRepository planRepository)
        {
            Plans = planRepository;
        }
        public IPlanRepository Plans { get; }
    }
}
