
public class Chara_dog : Chara_base
//Chara_baseとStart時にSettingConponentを呼び出すことを忘れずに！
{
    void Start()
    {
        SettingConponet();
        Invoke("Set_JanpUPFlag",1.0f);
    }

    void FixedUpdate()
    {
        BaseMove(5.0f);//引数は待機時間
    }
}
