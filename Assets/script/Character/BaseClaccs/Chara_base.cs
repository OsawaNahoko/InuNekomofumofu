using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chara_base : ClickEvent
{
    float AnimTime = -2.5f;

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;

        if(ResetSetting == true)
        {
            Reset();
            ResetSetting = false;//ResetSettingをOFF

        }else if(ResetSetting == false)
        {
            //何もしない
        }

        if(Loop >= WaitTime)
        {
            Reset();
            Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
            Set_DownAnime();
            Invoke("OnMove",2.5f);
        }
    }


    void Reset()
    {
        Loop = AnimTime;//AnimTimeをLoopに代入
        Set_JanpUPFlag();
    }

}

