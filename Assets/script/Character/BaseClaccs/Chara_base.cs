using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chara_base : ClickEvent
{
    public Text LoopText;
    string loopString;

    float AnimTime = -2.0f;

    public void Test()
    {
            loopString    = Loop.ToString("F2");
            LoopText.text = loopString;

    }

    public void BaseMove(float WaitTime)
    {
        Loop += Time.deltaTime;

        if(ResetSetting == true)
        {
            Reset();
            ResetSetting = false;//Loop変数リセットFlagをfalseに
            

        }else if(ResetSetting == false)
        {
            //何もしない
        }

        if(Loop >= WaitTime)
        {
            Reset();
            Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
            m_Animator.SetBool("JanpDownFlag",true);
            Invoke("OnMove",1.5f);
        }
    }

    public void SettingFlag()
    {
        m_Animator.SetBool("JanpUPFlag",true);
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Reset();
    //     m_Animator.SetBool("JanpDownFlag",true);
    //     OnMove();
    // }

    void Reset()
    {
        Loop = AnimTime;//AnimTimeをLoopに代入
        m_Animator.SetBool("JanpUPFlag",false);
    }


}

