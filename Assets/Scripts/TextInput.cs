using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class TextInput : MonoBehaviour
{

    public Text inputField;
    int x = 0;
    string userInput;
    public Button enterButton;
    public Button deleteButton;
    GameController controller;
    public Button ю;
    public Button а;
    public Button б;
    public Button ц;
    public Button д;
    public Button е;
    public Button ф;
    public Button г;
    public Button х;
    public Button и;
    public Button й;
    public Button к;
    public Button л;
    public Button м;
    public Button н;
    public Button о;
    public Button п;
    public Button я;
    public Button р;
    public Button с;
    public Button т;
    public Button у;
    public Button ж;
    public Button в;
    public Button ь;
    public Button ы;
    public Button ш;
    public Button щ;
    public Button ч;
    public Button ъ;
    public Button э;
    public Button опнаек;
    
    void Awake()
    {
        controller = GetComponent<GameController>();
        enterButton.onClick.AddListener(AcceptStringInput);
        deleteButton.onClick.AddListener(DeleteLastSymbol);
        ю.onClick.AddListener(Print);
        а.onClick.AddListener(Print);
        б.onClick.AddListener(Print);
        ц.onClick.AddListener(Print);
        д.onClick.AddListener(Print);
        е.onClick.AddListener(Print);
        ф.onClick.AddListener(Print);
        г.onClick.AddListener(Print);
        х.onClick.AddListener(Print);
        и.onClick.AddListener(Print);
        й.onClick.AddListener(Print);
        к.onClick.AddListener(Print);
        л.onClick.AddListener(Print);
        м.onClick.AddListener(Print);
        н.onClick.AddListener(Print);
        о.onClick.AddListener(Print);
        п.onClick.AddListener(Print);
        я.onClick.AddListener(Print);
        р.onClick.AddListener(Print);
        с.onClick.AddListener(Print);
        т.onClick.AddListener(Print);
        у.onClick.AddListener(Print);
        ж.onClick.AddListener(Print);
        в.onClick.AddListener(Print);
        ы.onClick.AddListener(Print);
        ь.onClick.AddListener(Print);
        ш.onClick.AddListener(Print);
        щ.onClick.AddListener(Print);
        ч.onClick.AddListener(Print);
        ъ.onClick.AddListener(Print);
        э.onClick.AddListener(Print);
        опнаек.onClick.AddListener(Print);
        
    }

   void AcceptStringInput() 
    {
        userInput = inputField.text.ToLower();
        controller.DisplayCommandText(userInput);
        char[] delimiterCharacters = { '_' };
        string[] separatedInputWords = userInput.Split(delimiterCharacters);

        for (int i = 0; i < controller.inputActions.Length; i++)
        {
            InputAction inputAction = controller.inputActions[i];
            if(inputAction.keyWord == separatedInputWords[0])
            {
                inputAction.RespondToInput(controller, separatedInputWords);
            }
        }

        InputComplete();
    
    }

   void DeleteLastSymbol()
   {
        if (x>-1)
        inputField.text = inputField.text.Remove(x);
       
    }
   void Print()
    {
 
        string nameButton = EventSystem.current.currentSelectedGameObject.name;
        if (nameButton == "ю")
            inputField.text += "Ю";
        else if (nameButton == "а")
            inputField.text += "А";
        else if (nameButton == "б")
            inputField.text += "Б";
        else if (nameButton == "ц")
            inputField.text += "Ц";
        else if (nameButton == "д")
            inputField.text += "Д";
        else if (nameButton == "е")
            inputField.text += "Е";
        else if (nameButton == "ф")
            inputField.text += "Ф";
        else if (nameButton == "г")
            inputField.text += "Г";
        else if (nameButton == "х")
            inputField.text += "Х";
        else if (nameButton == "и")
            inputField.text += "И";
        else if (nameButton == "й")
            inputField.text += "Й";
        else if (nameButton == "к")
            inputField.text += "К";
        else if (nameButton == "л")
            inputField.text += "Л";
        else if (nameButton == "м")
            inputField.text += "М";
        else if (nameButton == "н")
            inputField.text += "Н";
        else if (nameButton == "о")
            inputField.text += "О";
        else if (nameButton == "п")
            inputField.text += "П";
        else if (nameButton == "я")
            inputField.text += "Я";
        else if (nameButton == "р")
            inputField.text += "Р";
        else if (nameButton == "с")
            inputField.text += "С";
        else if (nameButton == "т")
            inputField.text += "Т";
        else if (nameButton == "у")
            inputField.text += "У";
        else if (nameButton == "ж")
            inputField.text += "Ж";
        else if (nameButton == "в")
            inputField.text += "В";
        else if (nameButton == "ь")
            inputField.text += "Ь";
        else if (nameButton == "ш")
            inputField.text += "Ш";
        else if (nameButton == "щ")
            inputField.text += "Щ";
        else if (nameButton == "ч")
            inputField.text += "Ч";
        else if (nameButton == "ъ")
            inputField.text += "Ъ";
        else if (nameButton == "э")
            inputField.text += "Э";
        else if (nameButton == "опнаек")
            inputField.text += "_";




    }

    void InputComplete()
    {
        /*controller.DisplayLoggedText();*/
        inputField.text = null;
       
    }

    private void Update()
    {
        x = inputField.text.Length-1;
    }



}
