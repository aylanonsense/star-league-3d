using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Pitcher : Entity
    {
        public new readonly EntityType type = EntityType.Pitcher;

        [SerializeField] private StrikeZone strikeZone;
    }
}
