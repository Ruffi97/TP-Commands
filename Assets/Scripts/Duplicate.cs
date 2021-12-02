using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : Command
{
    private GameObject _obj;

    public Duplicate(Transform transform, GameObject obj) : base(transform)
    {
        _obj = obj;
    }
    
    public override void Do()
    {
        Instantiate(_obj);
    }

    public override void Undo() {
        Destroy(_obj);
    }

    
}
