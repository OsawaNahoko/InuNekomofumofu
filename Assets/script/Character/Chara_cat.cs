
public class Chara_cat : Chara_base
//Chara_baseとStart時にSettingConponentを呼び出すことを忘れずに！
{
    void Start()
    {
        SettingConponet();
    }

    void FixedUpdate()
    {
        Test();
        BaseMove(2.0f);//引数は待機時間
    }
}
