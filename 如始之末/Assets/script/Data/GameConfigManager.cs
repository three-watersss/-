using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������Ϸ���ñ�Ĺ�����

public class GameConfigManager 
{
    public static GameConfigManager Instance = new GameConfigManager();

    private GameConfig cardData;//���Ʊ�
    private GameConfig enemyData;//���˱�
    private GameConfig levelData;//�ؿ���
    private TextAsset textAsset;
    public void Init()
    {
        textAsset = Resources.Load<TextAsset>("Data/card");
        cardData = new GameConfig(textAsset.text);

        textAsset = Resources.Load<TextAsset>("Data/enemy");
        enemyData = new GameConfig(textAsset.text);

        textAsset = Resources.Load<TextAsset>("Data/level");
        levelData = new GameConfig(textAsset.text);

    }
    public List<Dictionary<string,string>>GetCardLines()
    {
        return cardData.Getlines();
    }
    public List<Dictionary<string, string>> GetEnemyLines()
    {
        return enemyData.Getlines();
    }
    public List<Dictionary<string, string>> GetLevelLines()
    {
        return levelData.Getlines();
    }
    public Dictionary<string,string>GetCardById(string id)
    {
        return cardData.GetOneById(id);
    }
    public Dictionary<string, string> GetEnemyById(string id)
    {
        return enemyData.GetOneById(id);
    }
    public Dictionary<string, string> GetLevelById(string id)
    {
        return levelData.GetOneById(id);
    }
}
