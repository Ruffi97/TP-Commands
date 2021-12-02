using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{
    protected Transform _transform;

    protected Command(Transform transform) {
        _transform = transform;
    }

    public abstract void Do();
    public abstract void Undo();
}
