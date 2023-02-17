using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class coinsUpdateTextScript : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    private string textValue;

    // Start is called before the first frame update
    void Start()
    {
        coinsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public string getTextValue()
    {
        return textValue;
    }

    public void setTextValue(string value)
    {
        textValue = value;

        coinsText.text = textValue;
    }

    public Text getText()
    {
        return coinsText;
    }
}
