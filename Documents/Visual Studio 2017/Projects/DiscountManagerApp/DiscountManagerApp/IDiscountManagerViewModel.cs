using System;
using System.Collections.Generic;

namespace DiscountManagerApp
{
    public interface IDiscountManagerViewModel
    {
        decimal Price { get; set; }

        decimal Discount { get; set; }

        int Years { get; set; }

        AccountStatus Type { get; set; }

        List<Tuple<string, AccountStatus>> Types { get; }

        void Save();
    }
}
