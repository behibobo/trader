using System;
using TraderPanel.Customer.Repositories.Interfaces;

namespace TraderPanel.Customer.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        public RepositoryWrapper(ICustomerRepository customerRepository)
        {
            Customers = customerRepository;
        }
        public ICustomerRepository Customers { get; }
    }
}
