using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using DG.Tweening;
//ui������
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private Transform canvasTf;//�����任���

    private List<UIBase> uiList;//�洢���ع��Ľ��漯��

    private void Awake()
    {
        Instance = this;
        //�ҵ������еĻ���
        canvasTf = GameObject.Find("Canvas").transform;
        uiList = new List<UIBase>();
    }

    public UIBase ShowUI<T>(string uiName)where T:UIBase
    {
        UIBase ui = Find(uiName);
        if(ui==null)
        {
            //������û�� ��Ҫ��Resources/UI�ļ����м���
            GameObject obj = Instantiate(Resources.Load("UI/" + uiName), canvasTf) as GameObject;

            //������
            obj.name = uiName;

            //�����Ҫ�Ľű�
            ui = obj.AddComponent<T>();

            //��ӵ����Ͻ��д洢
            uiList.Add(ui);
        }
        else
        {
            //��ʾ
            ui.Show();
        }
        return ui;
    }

    //����
    public void HideUI(string uiName)
    {
        UIBase ui = Find(uiName);
        if(ui!=null)
        {
            ui.Hide();
        }
    }

    //�ر����н���
    public void CloseAllUI()
    {
        for(int i=uiList.Count-1;i>=0;i--)
        {
            Destroy(uiList[i].gameObject);
        }
        uiList.Clear();//��ռ���;
    }
    
    //�ر�ĳ������
    public void CloseUI(string uiName)
    {
        UIBase ui = Find(uiName);
        if(ui!=null)
        {
            uiList.Remove(ui);
            Destroy(ui.gameObject);
        }
    }

    //�Ӽ������ҵ����ֶ�Ӧ�Ľ���ű�
    public UIBase Find(string uiName)
    {
        for(int i=0;i<uiList.Count;i++)
        {
            if (uiList[i].name == uiName)
                return uiList[i];
        }
        return null;
    }

    //��������ͷ�����ж�ͼ����Ʒ
    public GameObject CreateActionIcon()
    {
        GameObject obj = Instantiate(Resources.Load("UI/actionIcon"), canvasTf) as GameObject;
        obj.transform.SetAsFirstSibling();//�����ڸ��������һλ
        return obj;
    }
    //�������˵ײ���Ѫ��
    public GameObject CreateHpItem()
    {
        GameObject obj = Instantiate(Resources.Load("UI/HpItem"), canvasTf) as GameObject;
        obj.transform.SetAsFirstSibling();//�����ڸ��������һλ
        return obj;
    }
    //��ʾ����
    public void ShowTip(string msg.Color,System.Action.callback=null)
    {

    }
}
