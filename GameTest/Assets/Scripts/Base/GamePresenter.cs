using Button;
using Circle;

namespace Base
{
    public class GamePresenter
    {
        public GamePresenter(GameModel gameModel, GameView gameView)
        {
            ButtonPresenter buttonPresenter = new ButtonPresenter(gameView.Button, gameModel.Button);
            CirclePresenter circlePresenter = new CirclePresenter(gameView.Circle, gameModel.Circle);
        }
    }
}