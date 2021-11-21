

using System;
namespace TraderPanel.Customer.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository Customers { get; }
    }
}
