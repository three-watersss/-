using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager 
{
    public static RoleManager Instance = new RoleManager();

    public List<string> cardList;//存储拥有的卡牌的id
    public void Init()//初始卡牌
    {
        cardList = new List<string>();
        //2张轻拳
        cardList.Add("1000");
        cardList.Add("1000");
        //1张重拳
        cardList.Add("1000");
        //1张侧踢
        cardList.Add("1000");
        //1张庐山升龙霸
        cardList.Add("1000");
        //1张小电池
        cardList.Add("1000");
        //1张电池
        cardList.Add("1000");
        //1张闪电五连鞭
        cardList.Add("1000");
    }
}
