using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    private Canvas canvas;

    public Button ExitButton;
    
    void Start()
    {
        canvas = GetComponent<Canvas>();
        Button btn = ExitButton.GetComponent<Button>();
        canvas.enabled = false;
        btn.onClick.AddListener(CloseInventory);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            canvas.enabled = !canvas.enabled;
    }

    private void CloseInventory() => canvas.enabled = false;
    
}
