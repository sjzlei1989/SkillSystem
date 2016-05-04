﻿using UnityEngine;
using System.Collections;
namespace Code.SkillSystem
{
    public enum eAction
    {
        Hp,
        Hit,
        Particle,
        ShakeCamera,
        Summon,
        AddBuff,
    }
    public class ActionBuilder : TBuilder<Action, Summon>
    {

        public ActionBuilder() { }

        void Add<T>(eAction id) where T : Action, new()
        {
            Add<T>((uint)id);
        }
    }
}