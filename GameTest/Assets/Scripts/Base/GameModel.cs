using Button;
using Circle;

namespace Base
{
    public class GameModel
    {
        public IButtonModel Button { get; }
        public ICircleModel Circle { get; }

        public GameModel()
        {
            Button = new ButtonModel();
            Circle = new CircleModel(Button);
        }
    }
}