using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InputManagerTurnBased : MonoBehaviour
{
    [SerializeField]
    private Button up;
    [SerializeField]
    private Button down;
    [SerializeField]
    private Button left;
    [SerializeField]
    private Button right;

    [SerializeField]
    private Button doTurn;

    [SerializeField]
    private Button undo;

    [SerializeField]
    private Button redo;

    [SerializeField]
    private CharacterMoveTurnBased character;

    [SerializeField] 
    UICommandList uiCommandList;


    private void OnEnable()
    {
        up?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.forward, 1f));
        down?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.back, 1f));
        left?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.left, 1f));
        right?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.right, 1f));

        undo.gameObject.SetActive(false);
        redo.gameObject.SetActive(false);

        doTurn.onClick.AddListener(() => character.DoMoves());
    }

    private void SendMoveCommand(Transform objectToMove, Vector3 direction, float distance)
    {
        ICommand movement = new Move(objectToMove, direction, distance);
        character?.AddCommand(movement);
        uiCommandList?.AddCommand(movement);

        

        
    }
}
