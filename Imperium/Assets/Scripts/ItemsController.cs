using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Items;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class ItemsController : MonoBehaviour
{
    public static List<Item> Items = new List<Item>();
    public static Dictionary<string, GameObject> ItemsObjects = new Dictionary<string, GameObject>();
    
    // public GameObject itemsPanel;
    //
    // public GameObject itemGameObject;
    // public void Equip(string id)
    // {
    //     if (Items.Any(x => x.ID == id))
    //     {
    //         Global.CurrItem = Items.First(x => x.ID == id);
    //         // armorObject.GetComponent<SpriteRenderer>().sprite = sprites[currItem];
    //     }
    // }
    //
    // public string AddItem(Item item)
    // {
    //     var panel = itemsPanel;
    //     
    //     if (panel == null) return item.ID;
    //     
    //     GameObject a = (GameObject)Instantiate(itemGameObject);
    //     var text = a.transform.FindChild("Text").gameObject;
    //     text.GetComponent<Text>().text =$"{item.Count}";
    //     var image = a.transform.FindChild("Icon").gameObject;
    //     image.GetComponent<Image>().sprite = sprites[item.Img];
    //     a.transform.SetParent(panel.transform, false);
    //         
    //     Items.Add(item);
    //     ItemsObjects.Add(item.ID, a);
    //
    //     return item.ID;
    // }
    //
    // public void EditUIItem(Item item)
    // {
    //     ModifyEach(Items.FindAll(x => x.ID == item.ID), x => item);
    //     var a = ItemsObjects[item.ID];
    //     var text = a.transform.FindChild("Text").gameObject;
    //     text.GetComponent<Text>().text =$"{item.Count}";
    //     var image = a.transform.FindChild("Icon").gameObject;
    //     image.GetComponent<Image>().sprite = sprites[item.Img];
    // }
    //
    // private void ModifyEach<T>(IList<T> source,
    //     Func<T,T> projection)
    // {
    //     for (var i = 0; i < source.Count; i++)
    //     {
    //         source[i] = projection(source[i]);
    //     }
    // }
    //
    // public Item GetItemById(string id) => Items.First(x => x.ID == id);

}
