using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
//敌人行动类型枚举
public enum ActionType
{
    None,
    Attack,//攻击
    UpInfection//感染值上升
}


/// <summary>
/// 敌人脚本
/// </summary>
public class enemy : MonoBehaviour
{
    public ActionType type;

    public GameObject hpItemObj;
    public GameObject actionObj;

    //ui相关
    public Transform attackTf;
    public Transform infectionTf;
    public Text infecionTxt;
    public Text hpTxt;
    public Image hpImg;

    //数值相关
    public int MaxInfection;
    public int CurInfection;
    public int MaxHp;
    public int CurHp;


    
    protected Dictionary<string, string> data;//敌人数据表信息
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
        //设置血条行动力位置
        hpItemObj.transform.position = Camera.main.WorldToScreenPoint(transform.position+Vector3.down*0.2f);
        actionObj.transform.position = Camera.main.WorldToScreenPoint(transform.Find("head").position);

        setRandomAction();

        //初始化数值
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

    //更新生命值
    public void UpdateHp()
    {
        hpTxt.text = CurHp + "/" + MaxHp;
        hpImg.fillAmount = (float)CurHp / (float)MaxHp;
    }

    //更新感染值
    public void UpdateInfection()
    {
        infecionTxt.text = CurInfection + "/" + MaxInfection;
    }

}
