using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICommandList : MonoBehaviour
{
    [SerializeField]
    private List<Move> commandList = new List<Move>();
    [SerializeField]
    private TextMeshProUGUI commandText;
    public void AddCommand(ICommand command)
    {
        commandList.Add(command as Move);
        UpdateUIList();
        
    }

    public void ClearList()
    {
        commandList.Clear();
    }

    private void UpdateUIList()
    {
        commandText.text = "Commands:";

        foreach (Move command in commandList)
        {
            commandText.text += "\n";

            Vector3 direction = command.GetMove();

            if (direction.x >= 1)
                commandText.text += "Right";
            else if (direction.x <= -1)
                commandText.text += "Left";
            else if (direction.z >= 1)
                commandText.text += "Up";
            else if (direction.z <= -1)
                commandText.text += "Down";

        }


    }
}
