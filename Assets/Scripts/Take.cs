using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "TextAdventure/InputActions/Take")]
public class Take : InputAction
{
    public override void RespondToInput(GameController controller, string[] separetedInputWords)
    {
        Dictionary<string, string> takeDictionary = controller.interactableItems.Take(separetedInputWords);

        if(takeDictionary != null)
        {
            controller.DisplayCommandText(controller.TestVerbDictionaryWithNoun(takeDictionary, separetedInputWords[0], separetedInputWords[1]));
        }
    }

}
