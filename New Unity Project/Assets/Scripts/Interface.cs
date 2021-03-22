using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public interface IFly
    {
        void Fly();
    }

    public interface IRotation
    {
        void Rotation();
    }

    public interface IFlicker
    {
        void Flicker();
    }

    public interface IAction
    {
        void Action();
    }

    public interface IInteractable : IAction
    {
        bool IsInteractable { get; }
    }

    public interface IInitialization
    {
        void Action();
    }
}
