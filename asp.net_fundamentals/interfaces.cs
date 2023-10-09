using System;

interface IEquatable<T>
{
    bool Equals(T obj);
}

public class car : IEquatable<Car>
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? Year { get; set; }


}