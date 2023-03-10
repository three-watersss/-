using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人管理器
/// </summary>

public class enemyManager 
{
    public static enemyManager Instance = new enemyManager();


    private List<enemy> enemyList;//存储战斗中的敌人
    /// <summary>
    /// 加载敌人资源
    /// <param name="id">关卡Id</param>
    public void LoadRes(string id)
    {
        enemyList = new List<enemy>();
        //Id     Name   EnemyIds       Pos
        //读取关卡信息
        Dictionary<string, string> levelData = GameConfigManager.Instance.GetLevelById(id);
        //敌人id信息
        string[] enemyIds = levelData["EnemyIds"].Split('=');
        string[] enemyPos = levelData["Pos"].Split('=');//敌人位置信息

        for (int i=0;i<enemyIds.Length;i++)
        {
            string enemyId = enemyIds[i];
            string[] posArr = enemyPos[i].Split(',');
            //敌人位置
            float x = float.Parse(posArr[0]);
            float y = float.Parse(posArr[1]);
            float z = float.Parse(posArr[2]);
            //根据敌人id获得单个敌人信息
            Dictionary<string, string> enemyData = GameConfigManager.Instance.GetEnemyById(enemyId);
            //从资源中加载对应的模型
            GameObject obj = Object.Instantiate(Resources.Load(enemyData["Model"])) as GameObject;
            enemy enemy = obj.AddComponent<enemy>();
            enemy.Init(enemyData);
            //存储到集合
            enemyList.Add(enemy);
            obj.transform.position = new Vector3(x, y, z);        
        }
    }
}
