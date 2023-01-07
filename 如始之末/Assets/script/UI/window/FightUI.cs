using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
//战斗界面
public class FightUI : UIBase 
{
    private Text cardCountTxt;//卡牌数量
    private Text noCardCountTxt;//弃牌堆数量
    private Text hpTxt;
    private Text powerTxt;
    private Image hpImage;
    private Text psTxt;//体力数值
    private void Awake()
    {
        cardCountTxt = transform.Find("hasCard/icon/Text").GetComponent<Text>();
        noCardCountTxt = transform.Find("noCard/icon/Text").GetComponent<Text>();
        powerTxt = transform.Find("").GetComponent<Text>();
        hpTxt = transform.Find("hp/moneyTxt").GetComponent<Text>();
        hpImage = transform.Find("hp/fill").GetComponent<Image>();
        psTxt = transform.Find("hp/fangfu/Text").GetComponent<Text>();
    }
    private void Start()
    {
        UpdateHp();
        UpdatePower();
        UpdateCardCount();
        UpdatePs();
        UpdateUsedCardCount();
    }
    //更新血量
    public void UpdateHp()
    {
        hpTxt.text = FightManager.Instance.CurHp + "/" + FightManager.Instance.MaxHp;
        hpImage.fillAmount = (float)FightManager.Instance.CurHp / (float)FightManager.Instance.MaxHp;

    }
    //更新义肢能量
    public void UpdatePower()
    {
        powerTxt.text = FightManager.Instance.CurPowerCount + "/" + FightManager.Instance.CurPowerCount;
    }
    //更新体力
    public void UpdatePs()
    {
        psTxt.text = FightManager.Instance.CurPs + "/" + FightManager.Instance.MaxPs;
    }
    //更新卡堆数量
    public void UpdateCardCount()
    {
        cardCountTxt.text = FightCardManager.Instance.cardList.Count.ToString();
    }
    //更新弃牌堆数量
    public void UpdateUsedCardCount()
    {
        noCardCountTxt.text = FightCardManager.Instance.usedCardList.Count.ToString();
    }

}
