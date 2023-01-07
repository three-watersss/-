using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
//ս������
public class FightUI : UIBase 
{
    private Text cardCountTxt;//��������
    private Text noCardCountTxt;//���ƶ�����
    private Text hpTxt;
    private Text powerTxt;
    private Image hpImage;
    private Text psTxt;//������ֵ
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
    //����Ѫ��
    public void UpdateHp()
    {
        hpTxt.text = FightManager.Instance.CurHp + "/" + FightManager.Instance.MaxHp;
        hpImage.fillAmount = (float)FightManager.Instance.CurHp / (float)FightManager.Instance.MaxHp;

    }
    //������֫����
    public void UpdatePower()
    {
        powerTxt.text = FightManager.Instance.CurPowerCount + "/" + FightManager.Instance.CurPowerCount;
    }
    //��������
    public void UpdatePs()
    {
        psTxt.text = FightManager.Instance.CurPs + "/" + FightManager.Instance.MaxPs;
    }
    //���¿�������
    public void UpdateCardCount()
    {
        cardCountTxt.text = FightCardManager.Instance.cardList.Count.ToString();
    }
    //�������ƶ�����
    public void UpdateUsedCardCount()
    {
        noCardCountTxt.text = FightCardManager.Instance.usedCardList.Count.ToString();
    }

}
