using System;

namespace Button
{
    public interface IButtonModel
    {
        event Action Clicked;

        void Click();
    }
}