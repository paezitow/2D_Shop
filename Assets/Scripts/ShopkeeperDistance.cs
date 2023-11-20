using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopkeeperDistance : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject table;
    private bool buttonInstantiated = false;
    private float distance;
    private LojaController lojaController;
    void Start()
    {
        this.lojaController = table.GetComponent<LojaController>();
    }
    void Update()
    {
        distance = (player.transform.position - transform.position).magnitude;
        popUpButton(distance);
    }

    private void popUpButton(float distance)
    {
        if(distance < 1.5f)
        {
            if (!buttonInstantiated)
            {
                Instantiate(button,new Vector3(transform.position.x + 0.8f, transform.position.y + 0.5f), Quaternion.identity);
                buttonInstantiated = true;
            }
        }
        else
        {
            lojaController.Hide();
            Destroy(GameObject.FindGameObjectWithTag("Button"));
            buttonInstantiated = false;
        }
    }
}
