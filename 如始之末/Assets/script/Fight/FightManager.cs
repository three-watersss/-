using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ս��ö��
public enum FightType
{ 
    None,
    Init,
    Player,//��һغ�
    Enemy,//���˻غ�
    Win,
    Lose
}

/// <summary>
/// ս��������
/// </summary>
public class FightManager : FightUnit
{
    public static FightManager Instance;
    public FightUnit fightUnit;//ս����Ԫ
    public int MaxHp;//�������ֵ
    public int CurHp;//��ǰ����ֵ
    public int MaxPowerCount;//�����֫����
    public int CurPowerCount;//��ǰ��֫����
    //��ʼ��
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
    //�л�ս������
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
        fightUnit.Init();//��ʼ��
    }
    private void Updata()
    {
        if(fightUnit!=null)
        {
            fightUnit.OnUpdate();
        }
    }
}