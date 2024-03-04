using System;
using System.Collections.Generic;
using System.Collections;
public interface IShape : ICloneable
{
    public double Area() => 0;
}
class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Area() => Length * Width;
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
class Trapezoid : IShape
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }
    public double Width { get; set; }
    public double Area() => ((Length1 + Length2) * Width) / 2;
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
public class Room<T> : IComparable, ICloneable where T : IShape
{
    public double Height { get; set; }
    public T Floor { get; set; }
    public double Volume() => Floor.Area() * Height;
    public object Clone()
    {
        Room<T> roomDeep = new Room<T>();
        roomDeep.Height = Height;
        roomDeep.Floor = (T)Floor.Clone();
        return roomDeep;
    }
    public int CompareTo(object t)
    {
        Room<T> room = t as Room<T>;
        if (room != null) return this.Floor.Area().CompareTo(room.Floor.Area());
        else throw new Exception("Unable to compare");
    }
}
class RoomComparerByVolume<T> : IComparer where T : IShape
{
    public int Compare(object o1, object o2)
    {
        Room<T> r1 = o1 as Room<T>;
        Room<T> r2 = o2 as Room<T>;
        if (r1 == null || r2 == null) throw new Exception("Unable to compare");
        if (r1.Volume() > r2.Volume()) return 1;
        else if (r1.Volume() < r2.Volume()) return -1;
        else return 0;
    }
}
