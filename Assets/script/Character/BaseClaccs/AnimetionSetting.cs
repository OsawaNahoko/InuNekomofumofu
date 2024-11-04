using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionSetting : ConpnentSetting
{
  
    public void Set_DownAnime()
    {
        m_Animator.SetBool("JanpDownFlag",true);
    }
    public void Set_JanpUPFlag()
    {
        m_Animator.SetBool("JanpUPFlag",true);
    }
    public void Set_mofumofuFlag()
    {
        m_Animator.SetBool("MofumofuFlag",true);
    }

        public void unSet_DownAnime()
    {
        m_Animator.SetBool("JanpDownFlag",false);
    }
    public void unSet_JanpUPFlag()
    {
        m_Animator.SetBool("JanpUPFlag",false);
    }
        public void unSet_mofumofuFlag()
    {
        m_Animator.SetBool("MofumofuFlag",false);
    }

}
