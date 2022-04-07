using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class GameLogCommand: IEquatable<GameLogCommand>
{
    [SerializeField] private string _name;


    public string Name { get => _name; }

    public UnityEvent onInvoke;

    public GameLogCommand(string name)
    {
        _name = name;
    }

    public bool Equals(GameLogCommand other)
    {
        return other.Name == _name;
    }

    public virtual void Invoke()
    {
        onInvoke.Invoke();
        Debug.Log("Command " + _name + " was called.");
    }
}
