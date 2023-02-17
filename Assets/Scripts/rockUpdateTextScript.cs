using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class rockUpdateTextScript : MonoBehaviour
{
    [SerializeField] private Text rockText;
    private string textValue;

    // Start is called before the first frame update
    void Start()
    {
        rockText = GetComponent<Text>();
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

        rockText.text = textValue;
    }

    public Text getText()
    {
        return rockText;
    }
}
