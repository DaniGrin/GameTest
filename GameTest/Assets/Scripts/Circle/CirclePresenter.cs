namespace Circle
{
    public class CirclePresenter
    {
        private readonly ICircleView _view;
        private readonly ICircleModel _model;

        public CirclePresenter(ICircleView view, ICircleModel model)
        {
            _view = view;
            _model = model;

            _model.ColorChanged += OnColorChanged;
        }

        private void OnColorChanged()
        {
            _view.SetColor(_model.R, _model.G, _model.B);
        }
    }
}