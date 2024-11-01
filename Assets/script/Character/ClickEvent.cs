using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : Movement
{
    int Count = 0;
    float Loop;
    bool ResetSetting;
    

    public void DelayClick()
    {
        if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();

        Count += 1;
        Boxcoll.enabled = false;
        ResetSetting = reset(true);
        
        Invoke("OnMove",1.0f);
    }

    bool reset(bool ResetFlag)
    {
        return true;
    }

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;
        if(ResetSetting) Loop = 0.0f;reset(false);

        Debug.Log($"Loop{Loop}");

        if(Loop > WaitTime)
        {
            if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();
            Loop = 0.0f;

            Boxcoll.enabled = false;

            Invoke("OnMove",1.0f);
        }
    }

}
