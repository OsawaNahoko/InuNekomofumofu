using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_base : Movement
{
    float Loop;

    public void Base(float WaitTime)
    {
        Loop += Time.deltaTime;
        if(ClickFlag == true)Loop = 0f;ClickFlag = false;

        if(Loop > WaitTime)
        {
            if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();

            Boxcoll.enabled = false;
            Loop = 0f;
            Invoke("OnMove",1.0f);
        }
    }

}

