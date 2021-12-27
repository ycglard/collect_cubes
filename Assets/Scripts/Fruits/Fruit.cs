using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    private string type;
    private bool playable;
    private float speed;
    private GameObject FruitModel;

    public Fruit(string type,float speed,bool playable)
    {
        this.type = type;
        this.playable = playable;
        this.speed = speed;
    }

    public bool isPlayable()
    {
        return playable;
    }

    public float getSpeed()
    {
        return speed;
    }

    public string getType()
    {
        return type;
    }

    public void SetFruitChild( GameObject f)
    {
        FruitModel = f;
    }

    public GameObject getFruitChild()
    {
        return FruitModel;
    }
}
