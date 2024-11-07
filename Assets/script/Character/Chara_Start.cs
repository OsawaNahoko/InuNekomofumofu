using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_Start : Chara_base
{
    // Start is called before the first frame update
    void Start()
    {
        SettingConponet();
        Invoke("Set_JanpUPFlag",1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartClick()
    {
        
    }
}
