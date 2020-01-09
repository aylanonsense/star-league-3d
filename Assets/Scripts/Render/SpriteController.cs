using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpriteController : BaseMonoBehaviour
    {
        [SerializeField] private SpriteSheet spriteSheet;

        private SpriteRenderer spriteRenderer;
        private Sprite[] sprites;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteSheet != null) {
                sprites = spriteSheet.GetSprites();
            }
        }

        public int GetNumSprites()
        {
            return sprites.Length;
        }

        public void SetSprite(int index = 0)
        {
            spriteRenderer.sprite = sprites[index];
        }

        public Vector3 GetPixelPosition()
        {
            Vector3 pos = transform.localPosition;
            Vector3 scale = transform.localScale;
            return new Vector3(pos.x * 32.0f / scale.x, pos.y * 32.0f / scale.y, pos.z * 32.0f / scale.z);
        }

        public void SetPixelPosition(float x = 0.00f, float y = 0.00f, float z = 0.00f)
        {
            Vector3 scale = transform.localScale;
            transform.localPosition = new Vector3(x * scale.x / 32.0f, y * scale.y /32.0f, z * scale.z / 32.0f);
        }
    }
}