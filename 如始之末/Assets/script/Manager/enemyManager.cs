using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���˹�����
/// </summary>

public class enemyManager 
{
    public static enemyManager Instance = new enemyManager();


    private List<enemy> enemyList;//�洢ս���еĵ���
    /// <summary>
    /// ���ص�����Դ
    /// <param name="id">�ؿ�Id</param>
    public void LoadRes(string id)
    {
        enemyList = new List<enemy>();
        //Id     Name   EnemyIds       Pos
        //��ȡ�ؿ���Ϣ
        Dictionary<string, string> levelData = GameConfigManager.Instance.GetLevelById(id);
        //����id��Ϣ
        string[] enemyIds = levelData["EnemyIds"].Split('=');
        string[] enemyPos = levelData["Pos"].Split('=');//����λ����Ϣ

        for (int i=0;i<enemyIds.Length;i++)
        {
            string enemyId = enemyIds[i];
            string[] posArr = enemyPos[i].Split(',');
            //����λ��
            float x = float.Parse(posArr[0]);
            float y = float.Parse(posArr[1]);
            float z = float.Parse(posArr[2]);
            //���ݵ���id��õ���������Ϣ
            Dictionary<string, string> enemyData = GameConfigManager.Instance.GetEnemyById(enemyId);
            //����Դ�м��ض�Ӧ��ģ��
            GameObject obj = Object.Instantiate(Resources.Load(enemyData["Model"])) as GameObject;
            enemy enemy = obj.AddComponent<enemy>();
            enemy.Init(enemyData);
            //�洢������
            enemyList.Add(enemy);
            obj.transform.position = new Vector3(x, y, z);        
        }
    }
}
