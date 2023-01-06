using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private void Start()
    {
        //初始化音频管理器
        AudioManager.Instance.Init();
        //播放bgm
        AudioManager.Instance.PlayBGM("bgm1");
        //初始化配置表
        GameConfigManager.Instance.Init();
        //初始化用户信息
        RoleManager.Instance.Init();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FightManager.Instance.ChangeType(FightType.Init);//战斗初始化
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
