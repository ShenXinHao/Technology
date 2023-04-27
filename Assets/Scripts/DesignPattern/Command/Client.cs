using System.Collections;
using System.Collections.Generic;
using DesignPattern.Command;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public GameObject Text;

    public GameObject Img;

    private Image img;

    private Text text;
    private PressKeyCommand pressKeyCommand;
    public List<KeyCode> KeyCodes;
    // Start is called before the first frame update
    void Start()
    {
        text = Text.GetComponent<Text>();
        img = Img.GetComponent<Image>();
     
        MyData myData = new MyData(text, img);
       pressKeyCommand = new PressKeyCommand(myData);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCodes[0]))
        {
            // img.color = Color.black;
            // text.text = "PRESS KEY :" + KeyCode.J;  
            pressKeyCommand.Excute();
        }
    }

   public class MyData
   {
        public Text txt;
        public Image img;
        public MyData(Text txt, Image img)
        {
            this.txt = txt;
            this.img = img;
        }
        
        
    }
}
