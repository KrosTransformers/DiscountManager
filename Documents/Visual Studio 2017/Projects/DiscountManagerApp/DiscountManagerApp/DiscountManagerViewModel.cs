using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DiscountManagerApp
{
    public class DiscountManagerViewModel : INotifyPropertyChanged, IDiscountManagerViewModel
    {
        private DiscountManagerDto _discountManagerModel;
        private IDiscountRepository _discountRepository;
        private IDiscountManagerService _discountService;
        private decimal _price = 0;
        private int _years = 0;
        private AccountStatus _type = AccountStatus.NotRegistered;
        private decimal _discount = 0;

        public DiscountManagerViewModel(IDiscountManagerService discountService, 
            IDiscountRepository discountRepository)
        {
            _discountService = discountService;
            _discountRepository = discountRepository;
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                Years = (int)_price;
                ApplyDiscount();
            }
        }


        public int Years
        {
            get => _years;
            set
            {
                _years = value;
                NotifyPropertyChanged();
                Discount = _discountService.ApplyDiscount(Price, Type, Years);
            }
        }

        public AccountStatus Type
        {
            get => _type;
            set
            {
                _type = value;
                Discount = _discountService.ApplyDiscount(Price, Type, Years);
            }
        }
        private void ApplyDiscount()
        {
            Discount = _discountService.ApplyDiscount(Price, Type, Years);
        }

        public List<Tuple<string, AccountStatus>> Types { get; }
            = new List<Tuple<string, AccountStatus>>()
            { new Tuple<string, AccountStatus>("Typ 1", AccountStatus.NotRegistered  ),
              new Tuple<string, AccountStatus>("Typ 2", AccountStatus.SimpleCustomer ),
              new Tuple<string, AccountStatus>("Typ 3", AccountStatus.ValuableCustomer ),
              new Tuple<string, AccountStatus>("Typ 4", AccountStatus.MostValuableCustomer ) };


        public decimal Discount
        {
            get => _discount;
            set
            {
                _discount = value;
                NotifyPropertyChanged();
            }
        }

        public bool ZobrazMa { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Save()
        {
            _discountRepository.SaveAll(new DiscountManagerDto() { Amount = Price, Type = Type, Years = Years });
        }
    }
}
