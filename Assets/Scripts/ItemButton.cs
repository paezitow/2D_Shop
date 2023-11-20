using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    [SerializeField] private Item item;
    //private LojaController lojaController;
    //[SerializeField] private GameObject table;
    private Player player;
    [SerializeField] private GameObject playerGo;

    private void Start()
    {
        this.playerGo = GameObject.FindGameObjectWithTag("Player");
        //this.lojaController = table.GetComponent<LojaController>();
        this.player = playerGo.GetComponent<Player>();
    }

    public void ButtonByItem(GameObject item)
    {
        print("comprou item");
        this.player.BuyItem(item);
    }

}
