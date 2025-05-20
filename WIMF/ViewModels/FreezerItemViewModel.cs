using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WIMF.Models;


namespace WIMF.ViewModels
{
    internal class FreezerItemViewModel : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private DateTime dateAdded = DateTime.Now;
        public ObservableCollection<FreezerItem> FreezerItems { get; set; }
        public ICommand AddFreezerItemCommand{ get; }

        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get => description;
            set { description = value; OnPropertyChanged(); }
        }

        public DateTime DateAdded
        {
            get => dateAdded;
            set { dateAdded = value; OnPropertyChanged(); }
        }

        public FreezerItemViewModel()
        {
            FreezerItems = new ObservableCollection<FreezerItem>
            {
                new FreezerItem { Id = 1, Name = "Ice Cream", Description = "Vanilla ice cream", DateAdded = DateTime.Now },
                new FreezerItem { Id = 2, Name = "Frozen Peas", Description = "Green peas", DateAdded = DateTime.Now },
                new FreezerItem { Id = 3, Name = "Frozen Chicken", Description = "Chicken breasts", DateAdded = DateTime.Now }
            };

            AddFreezerItemCommand = new Command(AddFreezerItem);
        }

        public void AddFreezerItem()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return;

            FreezerItems.Add(new FreezerItem { Id = 1, Name = Name, Description = Description, DateAdded = DateAdded });
            Name = string.Empty;
            Description = string.Empty;
            DateAdded = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
