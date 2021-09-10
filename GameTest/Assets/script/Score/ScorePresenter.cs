using UnityEditor;
using UnityEngine;

namespace Assets.script.Score
{
    public class ScorePresenter
    {
        private readonly IScoreView _view;
        private readonly IScoreModel _model;

        public ScorePresenter(IScoreView view , IScoreModel model)
        {
            _view = view;
            _model = model;
            _model.ScoreChange += OnScoreChange;
        }
        private void OnScoreChange()
        {
            _view.SetScore(_model.GetCount());
        }

    }
    
}