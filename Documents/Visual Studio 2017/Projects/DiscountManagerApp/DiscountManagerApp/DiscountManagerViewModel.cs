using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DiscountManagerApp
{
    public class DiscountManagerViewModel : INotifyPropertyChanged
    {
        private DiscountManagerDto _discountManagerModel;
        private Class1 _discountCalculatorService = new Class1();
        private decimal _amount = 0;
        private int _years = 0;
        private int _type = 0;
        private decimal _discount = 0;

        public DiscountManagerViewModel()
        {
            _discountManagerModel = new DiscountManagerDto() { Amount = Amount, Years = Years, Type = Type };
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                NotifyPropertyChanged();
                Discount = _discountCalculatorService.Calculate(Amount, Type, Years);
            }
        }

        public int Years
        {
            get => _years;
            set
            {
                _years = value;
                NotifyPropertyChanged();
                Discount = _discountCalculatorService.Calculate(Amount, Type, Years);
            }
        }

        public int Type
        {
            get => _type;
            set
            {
                _type = value;
                NotifyPropertyChanged();
                Discount = _discountCalculatorService.Calculate(Amount, Type, Years);
            }
        }

        public List<Tuple<string, int>> Types { get; }
            = new List<Tuple<string, int>>() { new Tuple<string, int>("Typ 1", 1 ),
                                               new Tuple<string, int>("Typ 2", 2 ),
                                               new Tuple<string, int>("Typ 3", 3 ),
                                               new Tuple<string, int>("Typ 4", 4 ) };


        public decimal Discount
        {
            get => _discount;
            set
            {
                _discount = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
