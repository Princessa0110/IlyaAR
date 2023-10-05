using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Configs/ItemsConfig")]
public class ItemsConfig : ScriptableObject
{
    public List<Item> items;
}
