using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Batter : Entity
    {
        [SerializeField] private StrikeZone strikeZone;

        public void SetAim(int x, int y)
        {
            strikeZone.SetTarget(x, y);
        }
    }
}
