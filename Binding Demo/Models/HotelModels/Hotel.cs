using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Demo.Models.HotelModels
{
    public class Hotel : BaseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Room> Rooms { get; set; } = new ObservableCollection<Room>();
    }
}
