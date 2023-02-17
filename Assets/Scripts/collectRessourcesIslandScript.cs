using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectRessourcesIslandScript : MonoBehaviour
{
    [SerializeField] private string nameIsland;
    private GameObject islandObject;

    private islandCoinsScript islandCoins;
    private islandWoodScript islandWood;
    private islandRockScript islandRock;
    
    // Start is called before the first frame update
    void Start()
    {
        islandObject = GameObject.Find(nameIsland);

        if (islandObject != null)
        {
            islandCoins = islandObject.GetComponent<islandCoinsScript>();
            islandWood = islandObject.GetComponent<islandWoodScript>();
            islandRock = islandObject.GetComponent<islandRockScript>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        if (islandObject != null)
        {
            islandCoins = islandObject.GetComponent<islandCoinsScript>();
            islandWood = islandObject.GetComponent<islandWoodScript>();
            islandRock = islandObject.GetComponent<islandRockScript>();
        }

        if (islandCoins != null) islandCoins.GetCoins();
        if (islandWood != null) islandWood.GetWoods();
        if (islandRock != null) islandRock.GetRocks();
    }

    public void SetIslandObject(string islandString)
    {
        nameIsland = islandString;
        islandObject = GameObject.Find(nameIsland);
    }
}
