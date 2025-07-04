using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechJob
{
    public class Pallet
    {
        public int ID {get; set;}
        public double Width {get; set;}
        public double Height {get; set;}
        public double Depth {get; set;}
        public List<Box> Boxes {get; set;} = new List<Box>();

        public double Weight => Boxes.Sum(box => box.Weight) + 30;

        public DateTime ExpirationDate => Boxes.Count > 0 ? Boxes.Min(box => box.ExpirationDate) : DateTime.MaxValue;

        public double Volume => Boxes.Sum(box => box.Volume) + (Width * Height * Depth);
    }
    public class Box
    {
        public int ID {get; set;}
        public double Width {get; set;}
        public double Height {get; set;}
        public double Depth {get; set;}
        public double Weight {get; set;}
        public DateTime? ProductionDate {get; set;}

        public DateTime ExpirationDate => ProductionDate.HasValue ? ProductionDate.Value.AddDays(100) : DateTime.MaxValue;

        public double Volume => Width * Height * Depth;
    }


}
