using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandRockScript : MonoBehaviour
{
    [SerializeField] private float numberRockMax;
    [SerializeField] private float numberRock;
    [SerializeField] private float timeNumberRockMax;

    private GameObject ship;

    private InventoryRessourcesManagementScript inventoryRocks;

    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");

        inventoryRocks = ship.GetComponent<InventoryRessourcesManagementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float RockGet = numberRockMax * Time.deltaTime / timeNumberRockMax;
        if (numberRock < numberRockMax) AddRocks(RockGet);
    }

    public void GetRocks()
    {
        //Debug.Log("you get " + (int)numberRock + " Rocks");
        inventoryRocks.AddInventoryRock((int)numberRock);
        numberRock -= (int)numberRock;
    }

    private void AddRocks(float rock)
    {
        if (numberRock + rock > numberRockMax) numberRock = numberRockMax;
        else numberRock += rock;
    }

    public float GetMaxRock()
    {
        return numberRockMax;
    }

    public int GetNumberRock()
    {
        return (int)numberRock;
    }
}
