using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//战斗枚举
public enum FightType
{ 
    None,
    Init,
    Player,//玩家回合
    Enemy,//敌人回合
    Win,
    Lose
}

/// <summary>
/// 战斗管理器
/// </summary>
public class FightManager : FightUnit
{
    public static FightManager Instance;
    public FightUnit fightUnit;//战斗单元
    public int MaxHp;//最大生命值
    public int CurHp;//当前生命值
    public int MaxPowerCount;//最大义肢能量
    public int CurPowerCount;//当前义肢能量
    //初始化
    public void Init()
    {
        MaxHp = 100;
        CurHp = 100;
        MaxPowerCount = 10;
        CurPowerCount = 10;

    }
    private void Awake()
    {
        Instance = this;
    }
    //切换战斗类型
    public void ChangeType(FightType type)
    {
        switch(type)
        {
            case FightType.None:
                break;
            case FightType.Init:
                fightUnit = new FightInit();
                break;
            case FightType.Player:
                fightUnit = new Fight_PlayerTrun();
                break;
            case FightType.Enemy:
                fightUnit = new Fight_EnemyTurn();
                break;
            case FightType.Win:
                fightUnit = new Fight_Win();
                break;
            case FightType.Lose:
                fightUnit = new Fight_Lose();
                break;

        }
        fightUnit.Init();//初始化
    }
    private void Updata()
    {
        if(fightUnit!=null)
        {
            fightUnit.OnUpdate();
        }
    }
}