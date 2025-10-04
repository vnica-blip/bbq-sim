using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    //This component is placed on any object that is a keyItem pick up and to be placed in your "inventory"
    [Header("Inventory System: Item Details")]
    public string itemName = "Item";
    public int itemID = 0;
    public bool destroyOnUse = false;
    public Sprite displaySprite;
    public Color spriteDye = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    public GameObject fToPickUp;
    public AudioSource pickUpSFX;
    public bool isPickingUpItem = false;


    void Update()
    {

    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.F))
        {
            collision.TryGetComponent<PlayerInventory>(out PlayerInventory inv);
            inv.AddItemToInventory(new PlayerInventory.Item(itemName, itemID, displaySprite, spriteDye, destroyOnUse));

            isPickingUpItem = true;
                if (isPickingUpItem)
                {
                    Debug.Log("Picked up an item");
                }
            
            this.gameObject.SetActive(false);
            pickUpSFX.Play();
            if (this.gameObject.activeSelf)
            {
                fToPickUp.SetActive(true);
            }
            else
            {
                fToPickUp.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (this.gameObject.activeSelf)
        {
            fToPickUp.SetActive(true);
        }
        else
        {
            fToPickUp.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        fToPickUp.SetActive(false);
    }
}