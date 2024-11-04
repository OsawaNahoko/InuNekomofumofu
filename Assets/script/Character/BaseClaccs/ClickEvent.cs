using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : Movement
{
    public Text CountText;
    string Countstring;

    public Text LoopText;
    string loopString;

    [HideInInspector] public float Loop;
    [HideInInspector] public bool ResetSetting = false;

    int Count = 0;

    public void DelayClick()
    {
        Count += 1;//もふもふカウント＋１

        CountLog();//クリア時の文字を更新

        Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
        ResetSetting    = true; //Loop変数リセットFlagをtrueに

        Set_mofumofuFlag();
        Invoke("Set_DownAnime",0.5f);//移動アニメーションを再生
        Invoke("OnMove",2.0f);  //キャラクターを移動
    }

    public void CountLog()
    {
            Countstring = Count.ToString();
            CountText.text = Countstring;
    }
    
        void LoopLog()
    {
            loopString    = Loop.ToString("F2");
            LoopText.text = loopString;

    }
    
}
