using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public List<Item> itensNoInventario = new List<Item>();

    public void AdicionarItemAoInventario(Item item)
    {
        itensNoInventario.Add(item);
    }
}
