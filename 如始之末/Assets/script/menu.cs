using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private void Start()
    {
        //��ʼ����Ƶ������
        AudioManager.Instance.Init();
        //����bgm
        AudioManager.Instance.PlayBGM("bgm1");
        //��ʼ�����ñ�
        GameConfigManager.Instance.Init();
        //��ʼ���û���Ϣ
        RoleManager.Instance.Init();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FightManager.Instance.ChangeType(FightType.Init);//ս����ʼ��
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
