using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_base : Movement
{
    float Loop;

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;
        Debug.Log($"Loop{Loop}");
        
        if(ClickFlag() == true)Loop = 0f;Debug.Log("ClickFlagがONになりました。");

        if(Loop > WaitTime)
        {
            if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();
            Boxcoll.enabled = false;

            Invoke("OnMove",1.0f);
        }
    }

}

