using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class collisionEventZone : MonoBehaviour
{
    NavMeshAgent _playerNav;

    GameObject _islandPanel;

    coinsUpdateTextScript _coinsScript;
    islandCoinsScript _coinsIslandScript;

    rockUpdateTextScript _rockScript;
    islandRockScript _rockIslandScript;

    woodUpdateTextScript _woodScript;
    islandWoodScript _woodIslandScript;

    collectRessourcesIslandScript _collectRessourcesIslandScript;

    private void OnTriggerEnter(Collider other)
    {
    }
    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

        // Edit coins Text
        _coinsScript = _islandPanel.GetComponentInChildren<coinsUpdateTextScript>();
        _coinsIslandScript = other.gameObject.GetComponentInParent<islandCoinsScript>();

        if (_coinsScript != null && _coinsIslandScript != null && other.gameObject.tag == "EventZone")
        {
            _coinsScript.setTextValue("Coins : " + _coinsIslandScript.GetNumberCoins().ToString());
        }


        // Edit rock Text
        _rockScript = _islandPanel.GetComponentInChildren<rockUpdateTextScript>();
        _rockIslandScript = other.gameObject.GetComponentInParent<islandRockScript>();

        if (_rockScript != null && _rockIslandScript != null && other.gameObject.tag == "EventZone")
        {
            _rockScript.setTextValue("Rock : " + _rockIslandScript.GetNumberRock().ToString());
        }


        // Edit wood Text
        _woodScript = _islandPanel.GetComponentInChildren<woodUpdateTextScript>();
        _woodIslandScript = other.gameObject.GetComponentInParent<islandWoodScript>();

        if (_woodScript != null && _woodIslandScript != null && other.gameObject.tag == "EventZone")
        {
            _woodScript.setTextValue("Wood : " + _woodIslandScript.GetNumberWood().ToString());
        }

        // Edit Button Link To Island
        if (other.tag == "Dockage")
        {
            _collectRessourcesIslandScript = _islandPanel.GetComponentInChildren<collectRessourcesIslandScript>();
            _collectRessourcesIslandScript.SetIslandObject(other.gameObject.GetComponentInParent<islandInformationsScript>().GetName());
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        _playerNav = GetComponent<NavMeshAgent>();

        _islandPanel = GameObject.Find("Island Panel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}