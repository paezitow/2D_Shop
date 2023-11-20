using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<GameObject> itensNoInventario = new List<GameObject>();

    public void AdicionarItemAoInventario(GameObject item)
    {
        itensNoInventario.Add(item);
    }
}
