using UnityEngine;

namespace Fruits
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
    
    public class FruitScriptable : ScriptableObject
    {
        [SerializeField] private GameObject bananaMesh;
        [SerializeField] private GameObject hotDogMesh;
        [SerializeField] private GameObject oliveMesh;
    }
}