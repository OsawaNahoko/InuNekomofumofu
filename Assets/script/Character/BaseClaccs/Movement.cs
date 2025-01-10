using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : AnimetionSetting
{
    public int Chara_ID;//キャラクターによりレイヤー順序をズラす為の変数。

    float[] positionYArray = {2.25f,-1.6f};
    float[] positionXArray = {-6.0f,0.4f,6.0f};

    //ｙ軸は１か2.25上か下かの違い　ｘ軸は－６か０．４か６のうちどれか。左右真ん中の違い

    public void OnMove()
    {
        
        float x = positionXArray[Random.Range(0,positionXArray.Length)];
        float y = positionYArray[Random.Range(0,positionYArray.Length)];

        transform.position = new Vector3(x,y,0);

        //キャラクターのレイヤー順序を変更する。
        if(y == -1.6f)
        {
            m_Splaitrend.sortingOrder = 10 + Chara_ID;//下段に居たら手前のレイヤーに設定。
        }
        else if(y == 2.25f)
        {
            m_Splaitrend.sortingOrder = 100 + Chara_ID;//上段に居たら奥のレイヤーに設定。
        }

        unSet_DownAnime();
        unSet_mofumofuFlag();
        
        Set_JanpUPFlag();

        Invoke("enabledBoxcoll",1.0f);

    }

}
