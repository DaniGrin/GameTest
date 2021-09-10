using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresenter
{

    private readonly Ibuttonview _view;
    private readonly IButtonModel _model;

    public ButtonPresenter(Ibuttonview view, IButtonModel model)
    {
        _view = view;
        _model = model;

        _view.Clicked += onClicked;
    }
    private void onClicked()
    {
        _model.Click();
    }
}
