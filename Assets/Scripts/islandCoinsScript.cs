using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class islandCoinsScript : MonoBehaviour
{
    [SerializeField] private float numberCoinsMax;
    [SerializeField] private float numberCoins;
    [SerializeField] private float timeNumberCoinsMax;

    private GameObject ship;

    private InventoryRessourcesManagementScript inventoryCoins;

    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");

        inventoryCoins = ship.GetComponent<InventoryRessourcesManagementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float coinsGet = numberCoinsMax * Time.deltaTime / timeNumberCoinsMax;
        if (numberCoins < numberCoinsMax) AddCoins(coinsGet);
    }

    public void GetCoins()
    {
        Debug.Log(inventoryCoins);
        inventoryCoins.AddInventoryCoins((int)numberCoins);
        numberCoins -= (int)numberCoins;
    }

    private void AddCoins(float coin)
    {
        if (numberCoins + coin > numberCoinsMax) numberCoins = numberCoinsMax;
        else numberCoins += coin;
    }

    public float GetMaxCoins()
    {
        return numberCoinsMax;
    }

    public int GetNumberCoins()
    {
        return (int)numberCoins;
    }
}
