using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_base : Movement
{
    float Loop;

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;
        // bool Flag = MoveFlag(); 
        
        // if(Flag == true)
        // {
        //     Loop = 0.0f;

        //     Debug.Log($"Loop = {Loop}");
        // }

        if(Loop > WaitTime)
        {
            if(Boxcoll == null)Boxcoll = this.gameObject.GetComponent<BoxCollider2D>();
            Loop = 0.0f;
            Debug.Log($"Loop{Loop}");

            Boxcoll.enabled = false;

            Invoke("OnMove",1.0f);
        }
    }

}

