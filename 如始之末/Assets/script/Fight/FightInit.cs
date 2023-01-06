using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//战斗初始化
public class FightInit : FightUnit
{
    public override void Init()
    {
        //切换bgm
        AudioManager.Instance.PlayBGM("battle");
        //显示战斗界面
        UIManager.Instance.ShowUI<FightUI>("FightUI");
        //敌人生成
        enemyManager.Instance.LoadRes("");//这里读取关卡x的敌人信息，可以自由选择
        //初始化战斗卡牌
        FightCardManager.Instance.Init();
        //初始化战斗数值
        FightManager.Instance.Init();
    
    }
    public override void OnUpdate()
    {
        base.OnUpdate();
    }
}
