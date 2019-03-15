using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//分工合作，一个封装工厂类，一个只管调用。调用的要求我给你个名字，你通过名字返回出来一个物体，返回出什么物体我不管，但这个物体里面有个 API ，叫ShowMe.
//这样就把逻辑给分开了。
public class Food
{
    public virtual void ShowMe()
    {
        
    }
}

public class TomatoFood:Food
{
    public override void ShowMe()
    {
        //base.ShowMe();
        
    }
}
public class EggFood:Food
{
    public override void ShowMe()
    {
        //base.ShowMe();
    }
}

/// <summary>
/// 工厂类，会根据名字去 new 对象
/// </summary>
public class TeachFactory 
{
    public Food ShowFactory(string name)
    {
        if (name == "egg")
            return new EggFood();
        else if (name == "tomato")
            return new TomatoFood();
        else
            return null;
    }
}

public class Main
{
    public void MainShow()
    {
        TeachFactory tmp = new TeachFactory();
        Food tmpFood=tmp.ShowFactory("egg");
        tmpFood.ShowMe();
    }
}
