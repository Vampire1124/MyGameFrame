using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 把这个类变成一个功能类
/// </summary>
public class SpriteFactory : MonoBehaviour
{
    public Object[] allSprite;

   //工厂方法，变成我们想要的东西
    public void LoadSprite(string name)
    {
        allSprite = Resources.LoadAll(name);
    }
    public GameObject GetSprite(int index)
    {
        GameObject tmpObj = new GameObject("TmpGame");
        Image tmpImage = tmpObj.AddComponent<Image>();
        tmpImage.sprite = allSprite[index] as Sprite;
        return tmpObj;
    }
   

   
}
