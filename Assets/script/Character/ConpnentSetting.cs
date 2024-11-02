using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConpnentSetting : MonoBehaviour
{
    [HideInInspector]public  BoxCollider2D  Boxcoll;
    [HideInInspector]public  Animator       m_Animator;

    public void SettingConponet()
    {
        Boxcoll     = this.gameObject.GetComponent<BoxCollider2D>();//Boxコライダーを取得
        m_Animator  = this.gameObject.GetComponent<Animator>();     //Animetorを取得
    }

}
