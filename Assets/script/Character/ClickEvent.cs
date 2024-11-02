using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : Movement
{
    [HideInInspector] public float Loop;
    float AnimTime = -1.0f;

    int Count = 0;
 
    bool ResetSetting = false;

    public void DelayClick()
    {
        if(Boxcoll == null)

        Count += 1;//もふもふカウント＋１

        Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
        ResetSetting    = true; //Loop変数リセットFlagをtrueに

        Invoke("OnMove",1.0f);  //キャラクターを移動
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
