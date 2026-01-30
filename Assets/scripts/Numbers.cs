using UnityEngine;
namespace MyGame
{
    public class Numbers : MonoBehaviour

    {
       private int _intVariable = 7;
       private float _floatVariable = 7.87f;
       private bool _boolVariable = false;

     public void Start()
        {
            Debug.Log($"int={_intVariable}");
            Debug.Log($"float={_floatVariable}");
            Debug.Log($"bool={_boolVariable}");
        }
    }
}
