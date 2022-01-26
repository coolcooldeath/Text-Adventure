using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "TextAdventure/InputActions/Examine")]
public class Examine : InputAction
{
    public override void RespondToInput(GameController controller, string[] separetedInputWords)
    {
        controller.DisplayCommandText(controller.TestVerbDictionaryWithNoun(controller.interactableItems.examineDictionary,separetedInputWords[0],separetedInputWords[1]));
    }

}


