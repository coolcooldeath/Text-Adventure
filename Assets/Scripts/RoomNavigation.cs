using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    public Room currentRoom;
    private GameController controller;

    Dictionary<string, Room> exitDictionary = new Dictionary<string, Room>();

    void Awake()
    {
        controller = GetComponent<GameController>();
    }
    public void UnpackExitsInRoom()
    {
        for(int i = 0; i < currentRoom.exits.Length; i++)
        {
            exitDictionary.Add(currentRoom.exits[i].keyString, currentRoom.exits[i].valueRoom);
            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }

    public void AttemptToChangeRooms(string directionNoun)
    {
        if (exitDictionary.ContainsKey(directionNoun)) 
        {
            currentRoom = exitDictionary[directionNoun];
            controller.DisplayCommandText("�� ���������� " + directionNoun);
            controller.DisplayRoomText();
        }
        else
        {
            controller.DisplayCommandText("��� ���� " + directionNoun);
        }
            
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }
}
