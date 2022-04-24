using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnCustomCommand : MonoBehaviour
{
    // Drag and drop your Dialogue Runner into this variable.
    public DialogueRunner dialogueRunner;
    public DialogueManager dialogueManager;

    public void Awake()
    {

        // Create a new command called 'add_string_and_int', 
        // which logs its two parameters:
        dialogueRunner.AddCommandHandler<string, int>(
            "add_string_and_int",
            AddStringAndInteger
        );

        dialogueRunner.AddCommandHandler<string, string>("setPosition", setPositionCmd);
        dialogueRunner.AddCommandHandler<string, string>("setExpression", setExpressionCmd);
        dialogueRunner.AddCommandHandler<string, string>("setFocus", setFocusCmd);
        dialogueRunner.AddCommandHandler<string>("clearPosition", clearPositionCmd);
        dialogueRunner.AddCommandHandler("failed", failedCmd);
        dialogueRunner.AddCommandHandler<string, string>("succeeded", succeededCmd);
    }

    private void AddStringAndInteger(string str, int i = 5)
    {
        Debug.Log($"String: {str}, int: {i}");
    }

    private void setPositionCmd(string actor, string position)
    {
        Debug.Log("COMMAND: setPositionCmd " + actor + " " + position);
        dialogueManager.setPositionCmd(actor, position);
    }

    private void setExpressionCmd(string actor, string expression)
    {
        Debug.Log("COMMAND: setPositionCmd " + actor + " " + expression);
        dialogueManager.setExpressionCmd(actor, expression);
    }

    private void setFocusCmd(string actor, string state)
    {
        Debug.Log("COMMAND: setFocusCmd " + actor + " " + state);
        dialogueManager.setFocusCmd(actor, state);
    }

    private void clearPositionCmd(string position)
    {
        Debug.Log("COMMAND: clearPosition " + position);
        dialogueManager.clearPositionCmd(position);
    }

    private void failedCmd()
    {
        Debug.Log("COMMAND: failedCmd");
        dialogueManager.failedCmd();
    }

    private void succeededCmd(string name, string description)
    {
        Debug.Log("COMMAND: setPositionCmd " + name + " " + description);
        dialogueManager.succeededCmd(name, description);
    }
}
