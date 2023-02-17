using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class woodUpdateTextScript : MonoBehaviour
{
    [SerializeField] private Text woodText;
    private string textValue;

    // Start is called before the first frame update
    void Start()
    {
        woodText = GetComponent<Text>();
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

        woodText.text = textValue;
    }

    public Text getText()
    {
        return woodText;
    }
}
