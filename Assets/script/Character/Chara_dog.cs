
public class Chara_dog : Chara_base
{
    void Start()
    {
        SettingConponet();
    }


    void FixedUpdate()
    {
        Test();
        BaseMove(5.0f);//引数は待機時間
    }
}
