using Button;
using Circle;
using UnityEngine;

namespace Base
{
    public class GameView : MonoBehaviour
    {
        [SerializeField] private ButtonUnityView buttonUnityView;
        [SerializeField] private CircleUnityView circleUnityView;

        public IButtonView Button
        {
            get { return buttonUnityView; }
        }

        public ICircleView Circle => circleUnityView;
    }
}