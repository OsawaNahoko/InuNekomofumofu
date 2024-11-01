using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [HideInInspector]
    public BoxCollider2D  Boxcoll;
    public  bool Flag;

    float[] positionYArray = {1.0f,-3.0f};
    float[] positionXArray = {-6.0f,0.4f,6.0f};

//ｙ軸は１か３上か下かの違い　ｘ軸は－６か０．４か６のうちどれか。左右真ん中の違い

    public void OnMove()
    {
        float x = positionXArray[Random.Range(0,positionXArray.Length)];
        float y = positionYArray[Random.Range(0,positionYArray.Length)];

        Boxcoll.enabled = true;

        transform.position = new Vector3(x,y,0);
    }

    // public bool MoveFlag()
    // {
    //     bool result = false;

    //     if(result == false)
    //     {
    //         return false;
    //         Debug.Log($"MoveFlag = {result}");
    //     }
    //     else if(result == true)
    //     {
    //         result = false;
    //         Debug.Log($"MoveFlag = {result}");
    //     }
    //     Debug.Log($"MoveFlag = {result}");
    //     return result;
    // }

}
