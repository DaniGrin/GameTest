using System;

namespace Circle
{
    public interface ICircleModel
    {
        event Action ColorChanged;
        
        int R { get; }
        int G { get; }
        int B { get; }
    }
}