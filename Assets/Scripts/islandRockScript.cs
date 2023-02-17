using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandRockScript : MonoBehaviour
{
    [SerializeField] private float numberRockMax;
    [SerializeField] private float numberRock;
    [SerializeField] private float timeNumberRockMax;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float RockGet = numberRockMax * Time.deltaTime / timeNumberRockMax;
        if (numberRock < numberRockMax) AddRocks(RockGet);
    }

    public void GetRocks()
    {
        Debug.Log("you get " + (int)numberRock + " Rocks");
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
