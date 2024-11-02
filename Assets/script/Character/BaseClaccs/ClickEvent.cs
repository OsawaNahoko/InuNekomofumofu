using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : Movement
{
    [HideInInspector] public float Loop;

    int Count = 0;
 
    public bool ResetSetting = false;

    public void DelayClick()
    {
        if(Boxcoll == null)

        Count += 1;//もふもふカウント＋１

        Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
        ResetSetting    = true; //Loop変数リセットFlagをtrueに

        Invoke("OnMove",1.0f);  //キャラクターを移動
    }


}
