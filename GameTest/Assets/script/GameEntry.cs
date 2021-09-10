using UnityEditor;
using UnityEngine;
using Assets.script.Score;

namespace Assets.script
{
    public class GameEntry : MonoBehaviour
    {
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private Buttonview buttonview;
        private void Start()
        {
            ButtonModel buttonModel = new ButtonModel();
            ScoreModel scoreModel = new ScoreModel(buttonModel);
            ScorePresenter scorePresenter = new ScorePresenter(scoreView , scoreModel);

            
            ButtonPresenter buttonPresenter = new ButtonPresenter(buttonview , buttonModel);

           
        }




    }
}