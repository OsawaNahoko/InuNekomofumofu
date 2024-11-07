using System.Collections;
using UnityEngine;

public class Chara_cat : Chara_base
//Chara_baseとStart時にSettingConponentを呼び出すことを忘れずに！
{
    void Start()
    {
        SettingConponet();
        StartCoroutine(StartMove(2.5f));
    }

    IEnumerator StartMove(float WaitIETime)
    {
        yield return new WaitForSeconds(WaitIETime);
        Set_JanpUPFlag();
        Debug.Log("処理の見える化・猫");

        while(true)
        {
            BaseMove(2.0f);//引数は待機時間

            yield return null;
            continue;
        }
    }
}
