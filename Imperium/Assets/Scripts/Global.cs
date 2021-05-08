using System.Collections.Generic;
using Items;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static bool PlayerBreak = false;
    
    public static Item CurrItem = null;
    
    public List<Item> Items = new List<Item>();
}
