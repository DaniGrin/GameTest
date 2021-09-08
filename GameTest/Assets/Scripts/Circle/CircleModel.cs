using System;
using Button;

namespace Circle
{
    public class CircleModel : ICircleModel
    {
        public event Action ColorChanged;
        
        public int R { get; private set; }
        public int G { get; private set; }
        public int B { get; private set; }

        public CircleModel(IButtonModel buttonModel)
        {
            buttonModel.Clicked += OnButtonClicked;
        }

        private void OnButtonClicked()
        {
            GenerateRandomColor();
        }

        private void GenerateRandomColor()
        {
            Random random = new Random();

            R = random.Next(0, 255);
            G = random.Next(0, 255);
            B = random.Next(0, 255);
            
            CallColorChanged();
        }
        
        private void CallColorChanged()
        {
            ColorChanged?.Invoke();
        }
    }
}