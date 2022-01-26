using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{


    public Text displayText;
    public InputAction[] inputActions;
    string visibleStringToAdd;
    [HideInInspector] 
    public RoomNavigation roomNavigation;
    [HideInInspector]
    public List<string> interactionDescriptionsInRoom = new List<string>();
    [HideInInspector] public InteractableItems interactableItems;

    List<string> actionLog = new List<string>();
    void Awake()
    {
        interactableItems = GetComponent<InteractableItems>();
        roomNavigation = GetComponent<RoomNavigation>();
        
    }


    void UnpackRoom()
    {
        roomNavigation.UnpackExitsInRoom();
        PrepareObjectToTakeOrExamine(roomNavigation.currentRoom);
    }

    void PrepareObjectToTakeOrExamine(Room currentRoom)
    {
        for (int i = 0; i < currentRoom.interactableObjectsInRoom.Length; i++)
        {
            string descriptionNotInInventory = interactableItems.GetObjectsNotInEnventory(currentRoom, i);
            if (descriptionNotInInventory !=null)
            {
                interactionDescriptionsInRoom.Add(descriptionNotInInventory);
            }

            InteractableObject interactableInRoom = currentRoom.interactableObjectsInRoom[i];

            for (int j = 0; j < interactableInRoom.interactions.Length; j++)
            {
                Interaction interaction = interactableInRoom.interactions[j];
                if (interaction.inputAction.keyWord == "исследовать")
                {
                    interactableItems.examineDictionary.Add(interactableInRoom.noun, interaction.textResponse);

                }

                if (interaction.inputAction.keyWord == "взять")
                {
                    interactableItems.takeDictionary.Add(interactableInRoom.noun, interaction.textResponse);

                }
            }
        }
    }

    public string TestVerbDictionaryWithNoun(Dictionary<string,string> verbDictionary,string verb,string noun)
    {
        if (verbDictionary.ContainsKey(noun))
        {
            return verbDictionary[noun];
        }

        return " Ты не можешь " + verb + " " + noun;
    }

    void ClearCollectionsForNewRoom()
    {
        interactableItems.ClearCollections();
        interactionDescriptionsInRoom.Clear();
        roomNavigation.ClearExits();
    }



    void Start()
    {
        DisplayRoomText();
        /*DisplayLoggedText();*/
    }

    public void DisplayRoomText()
    {
        ClearCollectionsForNewRoom();
        UnpackRoom();

        string joinedInteractionDescriptions = string.Join("\n", interactionDescriptionsInRoom.ToArray());
        string combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;
        LogStringWithReturn(combinedText);
    }

    public void DisplayCommandText(string command)
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = displayText.text + "\n" + command + "\n";




    }

    public void LogStringWithReturn(string stringToAdd)
    {
        visibleStringToAdd = stringToAdd;
        StartCoroutine("PlayText");
        actionLog.Add(stringToAdd + "\n");
    }

    IEnumerator PlayText()
    {
        foreach (char c in visibleStringToAdd)
        {
            displayText.text += c;
            yield return new WaitForSeconds(0.04f);
        }
        displayText.text += "\n";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
