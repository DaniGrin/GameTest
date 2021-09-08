using UnityEngine;
using UnityEngine.UI;

namespace Circle
{
    public class CircleUnityView : MonoBehaviour, ICircleView
    {
        [SerializeField] private Image _image;
        
        public void SetColor(int r, int g, int b)
        {
            float red = (float)r / 255;
            float green = (float)g / 255;
            float blue = (float)b / 255;
            
            _image.color = new Color(red, green, blue);
        }
    }
}