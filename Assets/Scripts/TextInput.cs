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
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button �;
    public Button ������;
    
    void Awake()
    {
        controller = GetComponent<GameController>();
        enterButton.onClick.AddListener(AcceptStringInput);
        deleteButton.onClick.AddListener(DeleteLastSymbol);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        �.onClick.AddListener(Print);
        ������.onClick.AddListener(Print);
        
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
        if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "�")
            inputField.text += "�";
        else if (nameButton == "������")
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
