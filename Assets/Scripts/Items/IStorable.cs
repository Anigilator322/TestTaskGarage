using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Items
{
    public interface IStorable
    {
        void Store(Transform transform);
    }
}
