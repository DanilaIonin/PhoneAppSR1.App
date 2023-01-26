using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneAppSR1
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Phone phone;
        public ICommand Increase1 { get; }
        public ICommand Increase2 { get; }
        public ICommand Increase3 { get; }
        public ICommand Decrease1 { get; }
        public ICommand Decrease2 { get; }
        public ICommand Decrease3 { get; }

        public ICommand Calc { get; }


        public PhoneViewModel()
        {
            phone = new Phone();
            Increase1 = new Command(IncreaseSalary);
            Increase2 = new Command(IncreaseExp);
            Increase3 = new Command(IncreaseFactor);
            Decrease1 = new Command(DecreaseSalary);
            Decrease2 = new Command(DecreaseExp);
            Decrease3 = new Command(DecreaseFactor);
            Calc = new Command(PrizeVoid);
        }
        // decrease
        public void IncreaseSalary()
        {
            if (phone != null)
                Salary += 100;
        }

        public void IncreaseExp()
        {
            if (phone != null)
                Exp += 1;
        }

        public void IncreaseFactor()
        {
            if (phone != null)
                Factor = Math.Round(Factor + 0.01, 2);
        }

        public void DecreaseSalary()
        {
            if (phone != null)
                Salary -= 100;
        }
        public void DecreaseExp()
        {
            if (phone != null)
                Exp -= 1;
        }
        public void DecreaseFactor()
        {
            if (phone != null)
                Factor = Math.Round(Factor - 0.01, 2);
        }
        public void PrizeVoid()
        {
            if (phone != null)
                Prize = Salary * Exp * Factor;
        }

        public string FIO
        {
            get { return phone.FIO; }
            set
            {
                if (phone.FIO != value)
                {
                    phone.FIO = value;
                    OnPropertyChanged("FIO");
                }
            }
        }
        public string Stuff
        {
            get { return phone.Stuff; }
            set
            {
                if (phone.Stuff != value)
                {
                    phone.Stuff = value;
                    OnPropertyChanged("Stuff");
                }
            }
        }
        public int Salary
        {
            get { return phone.Salary; }
            set
            {
                if (phone.Salary != value)
                {
                    phone.Salary = value;
                    OnPropertyChanged("Salary");
                }
            }
        }
        public int Exp
        {
            get { return phone.Exp; }
            set
            {
                if (phone.Exp != value)
                {
                    phone.Exp = value;
                    OnPropertyChanged("Exp");
                }
            }
        }
        public double Factor
        {
            get { return phone.Factor; }
            set
            {
                if (phone.Factor != value)
                {
                    phone.Factor = value;
                    OnPropertyChanged("Factor");
                }
            }
        }
        public double Prize
        {
            get { return phone.Prize; }
            set
            {
                if (phone.Prize != value)
                {
                    phone.Prize = value;
                    OnPropertyChanged("Prize");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
