using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager 
{
    public static RoleManager Instance = new RoleManager();

    public List<string> cardList;//�洢ӵ�еĿ��Ƶ�id
    public void Init()//��ʼ����
    {
        cardList = new List<string>();
        //2����ȭ
        cardList.Add("1000");
        cardList.Add("1000");
        //1����ȭ
        cardList.Add("1000");
        //1�Ų���
        cardList.Add("1000");
        //1��®ɽ������
        cardList.Add("1000");
        //1��С���
        cardList.Add("1000");
        //1�ŵ��
        cardList.Add("1000");
        //1������������
        cardList.Add("1000");
    }
}
