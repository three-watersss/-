using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 主页面 : MonoBehaviour
{
    GameObject GameObject;
   public void BlackGirl()//进入黑袍人场景
    {
        SceneManager.LoadScene(3);//进入黑袍人对应的场景，编号可改
       
    }

   public void PoliceGirl()//进入安保人员1的场景
    {
        SceneManager.LoadScene(3);//进入安保人员1对应的场景，编号可改
       
    }

    public void DelButton()
    {
        gameObject.SetActive(false);//取消当前按钮，使得下一个出现
    }
}
