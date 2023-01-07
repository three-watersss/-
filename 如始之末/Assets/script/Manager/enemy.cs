using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
//�����ж�����ö��
public enum ActionType
{
    None,
    Attack,//����
    UpInfection//��Ⱦֵ����
}


/// <summary>
/// ���˽ű�
/// </summary>
public class enemy : MonoBehaviour
{
    public ActionType type;

    public GameObject hpItemObj;
    public GameObject actionObj;

    //ui���
    public Transform attackTf;
    public Transform infectionTf;
    public Text infecionTxt;
    public Text hpTxt;
    public Image hpImg;

    //��ֵ���
    public int MaxInfection;
    public int CurInfection;
    public int MaxHp;
    public int CurHp;


    
    protected Dictionary<string, string> data;//�������ݱ���Ϣ
    public void Init(Dictionary<string,string>data)
    {
        this.data = data;
    }
    void Start()
    {
        type = ActionType.None;
        hpItemObj = UIManager.Instance.CreateHpItem();
        actionObj = UIManager.Instance.CreateActionIcon();

        attackTf = actionObj.transform.Find("attack");
        infectionTf = actionObj.transform.Find("defend");

        infecionTxt = hpItemObj.transform.Find("fangyu/Text").GetComponent<Text>();
        hpTxt = hpItemObj.transform.Find("hpTxt").GetComponent<Text>();
        hpImg = hpItemObj.transform.Find("fill").GetComponent<Image>();
        //����Ѫ���ж���λ��
        hpItemObj.transform.position = Camera.main.WorldToScreenPoint(transform.position+Vector3.down*0.2f);
        actionObj.transform.position = Camera.main.WorldToScreenPoint(transform.Find("head").position);

        setRandomAction();

        //��ʼ����ֵ
        CurHp = int.Parse(data["Hp"]);
        MaxHp = CurHp;
        CurInfection = int.Parse(data["Infection"]);
        MaxInfection = CurInfection;

        UpdateHp();
        UpdateInfection();
    }
    public void setRandomAction()
    {
        int ran = Random.Range(1, 3);
        type = (ActionType)ran;
        switch(type)
        {
            case ActionType.None:
                break;
            case ActionType.Attack:
                break;
            case ActionType.UpInfection:
                break;
        }
            
     }

    //��������ֵ
    public void UpdateHp()
    {
        hpTxt.text = CurHp + "/" + MaxHp;
        hpImg.fillAmount = (float)CurHp / (float)MaxHp;
    }

    //���¸�Ⱦֵ
    public void UpdateInfection()
    {
        infecionTxt.text = CurInfection + "/" + MaxInfection;
    }

}
