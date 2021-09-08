using Base;
using UnityEngine;

public class GameEntry : MonoBehaviour
{
    [SerializeField] private GameView _gameView;
    
    private void Start()
    {
        GameModel gameModel = new GameModel();
        GamePresenter gamePresenter = new GamePresenter(gameModel, _gameView);
    }
}