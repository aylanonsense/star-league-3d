using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Batter))]
    public class BatterPlayerController : EntityComponent
    {
        private Batter batter;

        public override void Created()
        {
            batter = GetComponent<Batter>();
        }

        public override void UpdateState()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            int x, y;
            if (horizontalInput < -0.0f)
            {
                x = -1;
            } else if (horizontalInput > 0.0f)
            {
                x = 1;
            } else
            {
                x = 0;
            }
            if (verticalInput < -0.0f)
            {
                y = -1;
            }
            else if (verticalInput > 0.0f)
            {
                y = 1;
            }
            else
            {
                y = 0;
            }
            batter.SetAim(x, y);
        }
    }
}
