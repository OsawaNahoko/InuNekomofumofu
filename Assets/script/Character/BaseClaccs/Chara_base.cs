using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chara_base : ClickEvent
{
    public Text LoopText;
    string looptex;

    float AnimTime = -1.0f;

    public void Test()
    {
            looptex = Loop.ToString("F2");
            LoopText.text = looptex;

    }

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;

        if(ResetSetting == true)
        {
            Loop = AnimTime;     //AnimTimeをLoopに代入
            ResetSetting = false;//Loop変数リセットFlagをfalseに

        }else if(ResetSetting == false)
        {
            //何もしない
        }

        if(Loop >= WaitTime)
        {
           
            Loop = AnimTime;        //AnimTimeをLoopに代入
            Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
            m_Animator.SetTrigger("MoveTrigger");
            Invoke("OnMove",1.0f);  //キャラクターを移動
        }
    }

}

