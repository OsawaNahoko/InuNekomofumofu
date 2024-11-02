using UnityEngine.UI;

public class Chara_base : ClickEvent
{
    public Text LoopText;
    string looptex;

    public void Test()
    {
            looptex = Loop.ToString("F2");
            LoopText.text = looptex;

    }

}

