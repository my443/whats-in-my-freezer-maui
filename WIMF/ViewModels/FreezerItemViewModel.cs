using System.Collections.ObjectModel;
using WIMF.Models;

namespace WIMF.ViewModels
{
    internal class FreezerItemViewModel
    {
        public ObservableCollection<FreezerItem> FreezerItems { get; set; }

        public FreezerItemViewModel()
        {
            FreezerItems = new ObservableCollection<FreezerItem>
            {
                new FreezerItem { Id = 1, Name = "Ice Cream", Description = "Vanilla ice cream", DateAdded = DateTime.Now },
                new FreezerItem { Id = 2, Name = "Frozen Peas", Description = "Green peas", DateAdded = DateTime.Now },
                new FreezerItem { Id = 3, Name = "Frozen Chicken", Description = "Chicken breasts", DateAdded = DateTime.Now }
            };
        }
    }
}
