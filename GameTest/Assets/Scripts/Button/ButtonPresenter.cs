namespace Button
{
    public class ButtonPresenter
    {
        private readonly IButtonView _view;
        private readonly IButtonModel _model;

        public ButtonPresenter(IButtonView view, IButtonModel model)
        {
            _view = view;
            _model = model;

            _view.Clicked += OnClicked;
        }

        private void OnClicked()
        {
            _model.Click();
        }
    }
}