using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : Movement
{
    int Count = 0;

    public void DelayClick()
    {
        if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();
        Count += 1;
        Boxcoll.enabled = false;
        Invoke("OnMove",1.0f);
    }

}
