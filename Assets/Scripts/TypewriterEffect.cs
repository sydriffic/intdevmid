using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// i had to use a tutorial for the barebones of this
// made by Christina Creates Games https://www.youtube.com/watch?v=UR_Rh0c4gbY&ab_channel=ChristinaCreatesGames
// but i hope to elaborate on it so it only triggers OnCollisionEnter
public class TypewriterEffect : MonoBehaviour
{
    
    string text;

    TMP_Text textbox;

    //basic typewriter
    int visCharIndex; //the index of the current max visible character of the string
    Coroutine coroutine; //the coroutine that runs everything

    WaitForSeconds regDelay; //the delays used for a normal character
    WaitForSeconds punctDelay; //the delays used for punctuation

    //Typewriter Settings
    float cps = 20, punctTime = 0.5f; //characters per seond and punctuation delay time
    //im gonna make this public so i can edit them per text maybe idk


    // Start is called before the first frame update
    
    void Awake()
    {
        textbox = GetComponent<TMP_Text>();
        text = textbox.text;

        regDelay = new WaitForSeconds(1/cps);
        punctDelay = new WaitForSeconds(punctTime);
    }
    void Start()
    {

        SetText(text);
        Debug.Log(text);
    }

    void Update()
    {
        Debug.Log(textbox.maxVisibleCharacters + " " + visCharIndex);
    }

    public void SetText(string text)
    {
        //makes sure there is only one coroutine running
        if(coroutine != null)
        {
            StopCoroutine(coroutine); 
            Debug.Log("coroutine stopped");
        }
        //set the text and make sure everything is set to 0
        textbox.text = text;
        textbox.maxVisibleCharacters = 0;
        visCharIndex = 0;
    

        //starts the coroutine
        coroutine = StartCoroutine(routine:Typewriter());
        Debug.Log("coroutine started");
    }

//now from my two seconds of googling
//an ienumerator is basically an iterator
//i think i've used them in data structures before.
    IEnumerator Typewriter()
    {
        TMP_TextInfo textInfo = textbox.textInfo;

        //while the text isnt done typing
        while(visCharIndex < textInfo.characterCount + 1)
        {
            Debug.Log(textInfo.characterCount);
            //the character at This index
            //this does not use textbox.text because that could include tags
            //i.e. <b></b>
            //sorry to whoever has to read this code bc half of it is notetaking
            char c = textInfo.characterInfo[visCharIndex].character;
            textbox.maxVisibleCharacters++;
            Debug.Log("mvc increased");

            //if its punctuation
            if(c == '?' || c == '.' || c == ',' || c == ':' ||
                c == ';' || c == '!' || c == '-')
            {
                //use the punctuation delay DUH
                yield return punctDelay;
            }
            else
            {
                //otherwise use the normal delay
                yield return regDelay;
            }

            visCharIndex++;
            Debug.Log("vci increased");

            //Debug.Log(textbox.maxVisibleCharacters + " " + visCharIndex);
        }
    }
}
