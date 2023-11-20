using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour, ICostumeShop
{
    public int gold = 30;
    public PlayerInventory playerInventory;
    private LojaController lojaController;
    [SerializeField] private GameObject table;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    private GameObject inventory;
    void Start()
    {
        this.inventory = GameObject.FindGameObjectWithTag("Inventory");
        this.inventory.SetActive(false);
        this.lojaController = table.GetComponent<LojaController>();
    }
    private void Update()
    {
        this.textMeshProUGUI.text = "Gold: " + gold;
        if(GameObject.FindGameObjectWithTag("Button") != null){ 
            if(Input.GetKeyDown(KeyCode.E)) {
                this.lojaController.Show();
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OpenInventory();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            CloseInventory();
        }
    }
    public void BoughtItem(GameObject item)
    {
        Array itempanels = GameObject.FindGameObjectsWithTag("InventoryItemPanel");
        foreach(GameObject obj in itempanels)
        {
            if(obj.GetComponent<ItemButton>() == null)
            {
                Transform tsf = obj.transform;
                Instantiate(item, tsf.position, tsf.rotation);
                Destroy(obj);
            }
        }
    }

    public void BuyItem(GameObject item)
    {
        int price = Int32.Parse(item.GetComponent<TextMeshProUGUI>().text);
        BoughtItem(item);
        if (gold > price)
        {
            gold -= price;
        }
        else
        {
            print("Não há ouro suficiente.");
        }
    }

    public void OpenInventory()
    {
       if(this.inventory.activeSelf == false)
       {
           transform.GetComponent<PlayerMovement>().speed = 0f;
           this.inventory.SetActive(true);
       }
    }

    public void CloseInventory()
    {
        if(this.inventory.activeSelf == true)
        {
            transform.GetComponent<PlayerMovement>().speed = 5f;
            this.inventory.SetActive(false);
        }
    }
}
