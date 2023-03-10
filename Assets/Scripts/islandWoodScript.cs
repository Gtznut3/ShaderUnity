using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandWoodScript : MonoBehaviour
{
    [SerializeField] private float numberWoodMax;
    [SerializeField] private float numberWood;
    [SerializeField] private float timeNumberWoodMax;

    private GameObject ship;

    private InventoryRessourcesManagementScript inventoryWoods;

    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");

        inventoryWoods = ship.GetComponent<InventoryRessourcesManagementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float woodGet = numberWoodMax * Time.deltaTime / timeNumberWoodMax;
        if (numberWood < numberWoodMax) AddWood(woodGet);
    }

    public void GetWoods()
    {
        //Debug.Log("you get " + (int)numberWood + " Woods");
        inventoryWoods.AddInventoryWood((int)numberWood);
        numberWood -= (int)numberWood;
    }

    private void AddWood(float wood)
    {
        if (numberWood + wood > numberWoodMax) numberWood = numberWoodMax;
        else numberWood += wood;
    }

    public float GetMaxWood()
    {
        return numberWoodMax;
    }

    public int GetNumberWood()
    {
        return (int)numberWood;
    }
}
