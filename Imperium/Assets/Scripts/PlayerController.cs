using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Items;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D rb;
    private Vector2 _moveVelocity;
    
    public GameObject itemsPanel;
    
    public GameObject itemGameObject;
    public Sprite[] sprites;

    private bool Trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _moveVelocity = moveInput * speed;

        if (Trigger)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (ItemsController.Items.Count == 0)
                    wood_id = AddItem(new Item(ItemsController.Items.Count.ToString(), "Wood", 0, 10));
                else
                {
                    var item = GetItemById(wood_id);
                    item.Count += 10;
                    EditUIItem(item);
                }
            }
        }

    }

    private void FixedUpdate() {
        rb.MovePosition(rb.position + _moveVelocity * Time.fixedDeltaTime);
        

        if (_moveVelocity.x != 0 || _moveVelocity.y != 0)
        {
            float angle = Mathf.Atan2(_moveVelocity.y, _moveVelocity.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        }
        
        // float SRes = Vector2.Dot(rb.transform.right, _moveVelocity);
        // rb.transform.LookAt(_moveVelocity);
    }

    private int count = 0;

    private string wood_id = "";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tree"))
            Trigger = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Tree"))
            Trigger = false;
    }

    private string AddItem(Item item)
    {
        var panel = itemsPanel;
        
        if (panel == null) return item.ID;
        
        GameObject a = (GameObject)Instantiate(itemGameObject);
        var text = a.transform.FindChild("Text").gameObject;
        text.GetComponent<Text>().text =$"{item.Count}";
        var image = a.transform.FindChild("Icon").gameObject;
        image.GetComponent<Image>().sprite = sprites[item.Img];
        a.transform.SetParent(panel.transform, false);
            
        ItemsController.Items.Add(item);
        ItemsController.ItemsObjects.Add(item.ID, a);

        return item.ID;
    }

    private void EditUIItem(Item item)
    {
        ModifyEach(ItemsController.Items.FindAll(x => x.ID == item.ID), x => item);
        var a = ItemsController.ItemsObjects[item.ID];
        var text = a.transform.FindChild("Text").gameObject;
        text.GetComponent<Text>().text =$"{item.Count}";
        var image = a.transform.FindChild("Icon").gameObject;
        image.GetComponent<Image>().sprite = sprites[item.Img];
    }

    private void ModifyEach<T>(IList<T> source,
        Func<T,T> projection)
    {
        for (var i = 0; i < source.Count; i++)
        {
            source[i] = projection(source[i]);
        }
    }

    private Item GetItemById(string id) => ItemsController.Items.First(x => x.ID == id);
}
