using System;

namespace Button
{
    public interface IButtonView
    {
        event Action Clicked;
    }
}