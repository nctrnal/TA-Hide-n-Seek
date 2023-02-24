using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;

public class UI_Assistant : MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;

    public void Awake()
    {
        //find ui text message
        messageText = transform.Find("Message").Find("MassagesText").GetComponent<Text>();

        transform.Find("Message").GetComponent<Button_UI>().ClickFunc = () => { 
            if(textWriterSingle != null && textWriterSingle.isActive())
            {
                //curently active textwriter
                textWriterSingle.WriteAllAndDestroy();

                //change scene
                SceneManager.LoadScene("MainScene");

            }
            else
            {
                string[] messageArray = new string[]{
                "hallo bang, nama saya mas bro! saya adalah orang yang akan menemani perjalanan abang",
                "untuk barang pertama yang abang cari adalah rencong",
                "rencong adalah blbalabada",
                "gud luck mas bro"
                };

               

                string message = messageArray[Random.Range(0, messageArray.Length)];
                //string message = messageArray[Random.Range(0, messageArray.Length)];
                textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
            }

            
        };
       
    }

    public void Start()
    {
        //create text to message text
        //messageText.text = "Hello World!";
        //TextWriter.AddWriter_Static(messageText, "test" , 0.1f, true);
    }
}
