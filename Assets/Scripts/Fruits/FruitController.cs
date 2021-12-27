using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string type;
    [SerializeField] private float speed;
    [SerializeField] private bool isPlayable;
    
    private static Fruit fruit;
    void Start()
    {
        fruit = new Fruit(type, speed, isPlayable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setMesh()
    {
        
    }
}
