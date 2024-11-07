using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{ 
    public void DelayLoad_GameScene()
    {
        Debug.Log("ロードすると思う");
        Invoke("Load_GameScene",2.0f);
    }

     public void Load_GameScene()
    {
        SceneManager.LoadScene("1_1_Game");
    }

    public void Load_TitleScene()
    {
        SceneManager.LoadScene("0_1_Title");
    }

  
}
