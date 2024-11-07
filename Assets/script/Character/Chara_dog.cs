using System.Collections;
using UnityEngine;

public class Chara_dog : Chara_base
//Chara_baseとStart時にSettingConponentを呼び出すことを忘れずに！
{
    void Start()
    {
        SettingConponet();
        StartCoroutine(StartMove(3.0f));
    }

    IEnumerator StartMove(float WaitIETime)
    {
        yield return new WaitForSeconds(WaitIETime);
        while(true)
        {
            BaseMove(5.0f);//引数は待機時間
            
            yield return null;
            continue;
        }
    }
}
