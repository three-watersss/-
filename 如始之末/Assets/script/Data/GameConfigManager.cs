using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//整个游戏配置表的管理器

public class GameConfigManager 
{
    public static GameConfigManager Instance = new GameConfigManager();

    private GameConfig cardData;//卡牌表
    private GameConfig enemyData;//敌人表
    private GameConfig levelData;//关卡表
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
