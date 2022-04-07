using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Command List", menuName = "New Command List")]
public class GameLogCommandList : ScriptableObject
{
    [SerializeField]
    private  List<GameLogCommand> _commands;

    public void TryInvokeCommand(string name)
    {
        var command = new GameLogCommand(name);
        if (_commands.Contains(command))
        {
            _commands.Find(x => x.Equals(command)).Invoke();
        }
    }
}
