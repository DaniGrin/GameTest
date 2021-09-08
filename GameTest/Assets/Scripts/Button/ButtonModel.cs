using System;

namespace Button
{
    public class ButtonModel : IButtonModel
    {
        public event Action Clicked;
        
        public void Click()
        {
            CallClicked();
        }

        private void CallClicked()
        {
            Clicked?.Invoke();
        }
    }
}