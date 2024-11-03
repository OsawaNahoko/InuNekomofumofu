using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : ConpnentSetting
{

    float[] positionYArray = {2.25f,-1.6f};
    float[] positionXArray = {-6.0f,0.4f,6.0f};

//ｙ軸は１か2.25上か下かの違い　ｘ軸は－６か０．４か６のうちどれか。左右真ん中の違い

    public void OnMove()
    {
        m_Animator.SetBool("JanpDownFlag",false);
        m_Animator.SetBool("MofumofuFlag",false);

        float x = positionXArray[Random.Range(0,positionXArray.Length)];
        float y = positionYArray[Random.Range(0,positionYArray.Length)];

        Boxcoll.enabled = true;
        transform.position = new Vector3(x,y,0);

        if(y == -1.6f)
        {
            m_Splaitrend.sortingOrder = 5;
        }
        else if(y == 2.25f)
        {
            m_Splaitrend.sortingOrder = 4;
        }
        
        m_Animator.SetBool("JanpUPFlag",true);

        Debug.Log("OnMove");
    }

}
