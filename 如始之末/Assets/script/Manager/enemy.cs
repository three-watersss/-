using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
/// <summary>
/// ���˽ű�
/// </summary>
public class enemy : MonoBehaviour
{
    protected Dictionary<string, string> data;//�������ݱ���Ϣ
    public void Init(Dictionary<string,string>data)
    {
        this.data = data;
    }
}
