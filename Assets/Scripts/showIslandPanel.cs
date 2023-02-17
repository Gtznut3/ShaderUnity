using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showIslandPanel : MonoBehaviour
{

    [SerializeField] CanvasGroup islandCanvasGroup;
    [SerializeField] CanvasGroup buttonGroup;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Dockage")
        {
            buttonGroup.alpha = 1f;
            islandCanvasGroup.alpha = 1f;
            buttonGroup.interactable = true;
            Debug.Log("interactible true");
        }
        else if (other.gameObject.tag == "EventZone")
        {
            islandCanvasGroup.alpha = 1f;
            /*buttonGroup.alpha = 0f;*/
            buttonGroup.interactable = false;
            Debug.Log("interactible false");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Dockage") buttonGroup.alpha = 0f;

        islandCanvasGroup.alpha = 0f;
        buttonGroup.interactable = false;
    }

    void Start()
    {
        islandCanvasGroup = GameObject.Find("Island Panel").GetComponent<CanvasGroup>();
        buttonGroup = GameObject.Find("ButtonGetRessources").GetComponent<CanvasGroup>();

        buttonGroup.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
