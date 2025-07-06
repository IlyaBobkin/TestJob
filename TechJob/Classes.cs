using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TechJob
{
    public class Pallet
    {
        public Pallet(int id, double width, double height, double depth)
        {
            ID = id;
            Width = width;
            Height = height;
            Depth = depth;
        }

        public int ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public List<Box> Boxes { get; set; } = new List<Box>();

        public double Weight => Boxes.Sum(box => box.Weight) + 30;

        public DateTime ExpirationDate => Boxes.Count > 0
            ? Boxes.Min(box => box.ExpirationDate)
            : DateTime.MaxValue;

        public double Volume => Boxes.Sum(box => box.Volume) + (Width * Height * Depth);

        public bool CanAddBox(Box box)
        {
            return box.Width <= Width && box.Depth <= Depth;
        }
    }

    public class Box
    {
        public Box(int id, double width, double height, double depth, double weight, DateTime? productionDate)
        {
            ID = id;
            Width = width;
            Height = height;
            Depth = depth;
            Weight = weight;
            ProductionDate = productionDate;
        }

        public int ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime ExpirationDate => ProductionDate.HasValue ? ProductionDate.Value.AddDays(100) : DateTime.MaxValue;
        public double Volume => Width * Height * Depth;
    }
}
