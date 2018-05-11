using eCom.DAL.Data;
using eCom.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCom.DAL.Repo
{
    public class CustomerRepository: RepositoryBase<Customer>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
