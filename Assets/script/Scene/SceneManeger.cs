using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{ 
    void Delay_LoadGameScene()
    {

        Invoke("Delay_LoadGameScene",1.0f);
    }

     public void LoadGameScene()
    {
        SceneManager.LoadScene("1_1_Game");
    }

  
}
