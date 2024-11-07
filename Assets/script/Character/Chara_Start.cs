using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_Start : Chara_base
{
    // Start is called before the first frame update
    void Start()
    {
        SettingConponet();
        Invoke("Set_JanpUPFlag",0.3f);
    }

    public void StartClick()
    {
        
        Boxcoll.enabled = false;//Boxコライダーを無効（連続クリック対策）
        ResetSetting    = true; //Loop変数リセットFlagをtrueに

        Set_mofumofuFlag();
        Invoke("Set_DownAnime",0.5f);//移動アニメーションを再生
        Debug.Log("もふてる");
    }
}
