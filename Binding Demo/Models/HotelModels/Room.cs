using Binding_Demo.Functions;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Binding_Demo.Models.HotelModels
{
    public class Room : BaseModel
    {
        public int ID { get; set; }
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        public Hotel Hotel { get; set; }  
        public ICollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();

        public ICommand RemoveRoomCommand => new RelayCommand(() => HelperFunctions.GetViewModel().SelectedHotel.Rooms.Remove(this));

    }
}
