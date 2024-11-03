using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : Movement
{
    public Text CountText;
    string Countstring;

    [HideInInspector] public float Loop;
    [HideInInspector] public bool ResetSetting = false;

    int Count = 0;

    public void DelayClick()
    {
        
        Count += 1;//もふもふカウント＋１
        Debug.Log($"Count = {Count}");

        CountLog();//クリア時の文字を更新

        Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
        ResetSetting    = true; //Loop変数リセットFlagをtrueに

        m_Animator.SetBool("MofumofuFlag",true);
        Invoke("OnMove",1.4f);  //キャラクターを移動
    }

        public void CountLog()
    {
            Countstring = Count.ToString();
            CountText.text = Countstring;

    }


}
