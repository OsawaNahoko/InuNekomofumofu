using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConpnentSetting : MonoBehaviour
{
    [HideInInspector]public  BoxCollider2D  Boxcoll;
    [HideInInspector]public  Animator       m_Animator;
    [HideInInspector]public  SpriteRenderer m_Splaitrend;

    public void SettingConponet()
    {
        Boxcoll      = this.gameObject.GetComponent<BoxCollider2D>();//BoxCollider2Dを取得
        m_Animator   = this.gameObject.GetComponent<Animator>();     //Animetorを取得
        m_Splaitrend = this.GetComponent<SpriteRenderer>();          //SpriteRendererを取得
    }

}
