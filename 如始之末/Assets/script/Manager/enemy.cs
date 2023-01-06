using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
/// <summary>
/// 敌人脚本
/// </summary>
public class enemy : MonoBehaviour
{
    protected Dictionary<string, string> data;//敌人数据表信息
    public void Init(Dictionary<string,string>data)
    {
        this.data = data;
    }
}
