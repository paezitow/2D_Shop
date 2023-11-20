using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LojaController : MonoBehaviour
{
    [SerializeField] private Transform item;
    [SerializeField] private Transform itemShop;
    [SerializeField] Player player;

    private void Awake()
    {
        //item.gameObject.SetActive(false);
    }

    private void Start()
    {
        createItem(Resources.Load<Sprite>("Axe"), Resources.Load<Sprite>("Axe").name.ToString(), 10, -1);
        createItem(Resources.Load<Sprite>("Club"), Resources.Load<Sprite>("Club").name.ToString(), 15, 0);
        createItem(Resources.Load<Sprite>("Spear"), Resources.Load<Sprite>("Spear").name.ToString(), 20, 1);
        Hide();
    }

    private void createItem(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform itemTransform = Instantiate(item, itemShop);
        itemTransform.gameObject.name = itemName;
        RectTransform rectTransform = itemTransform.GetComponent<RectTransform>();

        rectTransform.anchoredPosition = new Vector2(0 , -110f * positionIndex);

        itemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        itemTransform.Find("itemPrice").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());
        itemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;

        
    }

    public void Show()
    {
        itemShop.gameObject.SetActive(true);
    }

    public void Hide()
    {
        itemShop.gameObject.SetActive(false);
    }
}