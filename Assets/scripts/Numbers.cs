using UnityEngine;

public class Numbers : MonoBehaviour 

{
    int _intVariable = 7;
    float _floatVariable = 7.87f;
    bool _boolVariable = false;

     void Start()
    {
        Debug.Log($"int={_intVariable}");
        Debug.Log($"float ={_floatVariable}");
        Debug.Log($"bool ={_boolVariable}");
    }
}
