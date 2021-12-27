using UnityEngine;

namespace Fruits
{
    [CreateAssetMenu(fileName = "FruitSO", menuName = "Fruit", order = 0)]
    
    public class FruitScriptable : ScriptableObject
    {
        [SerializeField] private GameObject bananaMesh;
        [SerializeField] private GameObject hotDogMesh;
        [SerializeField] private GameObject oliveMesh;
        [SerializeField] private GameObject startPoint;
        public GameObject getFruitModel(string f)
        {
            if (f == "BANANA")
                return bananaMesh;
            if (f == "HOTDOG")
                return hotDogMesh;
            if (f == "OLIVE")
                return oliveMesh;
            else 
                return bananaMesh;
        }
    }
}