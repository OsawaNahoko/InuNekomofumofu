using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : Movement
{
    int Count = 0;
    public float Loop;
    bool ResetSetting = false;

    public void DelayClick()
    {
        if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();

        Count += 1;
        Boxcoll.enabled = false;
        ResetSetting = true;
        Debug.Log($"DwlayClick動いてます");
        OnMove();
        // Invoke("OnMove",1.0f);
    }

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;

        if(ResetSetting == true)
        {
            Loop = 0.0f;
            Debug.Log($"ResetSetting = {ResetSetting}");
            ResetSetting = false;

        }else if(ResetSetting == false)
        {
            
        }

        Debug.Log($"Loop{Loop}");

        if(Loop >= WaitTime)
        {
            if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();
            Loop = 0.0f;

            Boxcoll.enabled = false;
            OnMove();
            // Invoke("OnMove",1.0f);
        }
    }

}
