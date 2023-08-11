using Binding_Demo.Models;
using Binding_Demo.Models.HotelModels;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Binding_Demo.ViewModel
{
    public class ViewModel : BaseModel
    {
        public ObservableCollection<Hotel> Hotels { get; set; } = new ObservableCollection<Hotel>();

        public Hotel SelectedHotel { get; set; }
        public Room SelectedRoom { get; set; }

        public ViewModel()
        {
            Hotels.Add(new Hotel() { ID = 1, Name = "Hotel 1" });
            Hotels.Add(new Hotel() { ID = 2, Name = "Hotel 2" });
            Hotels.Add(new Hotel() { ID = 3, Name = "Hotel 3" });
        }

        #region Commands
        public ICommand AddRoomCommand => new RelayCommand(() => AddRoom(),
            () => SelectedHotel != null);

        #endregion

        #region Functions

        private void AddRoom()
        {
            SelectedHotel.Rooms.Add(new Room());
        }

        #endregion

    }
}
