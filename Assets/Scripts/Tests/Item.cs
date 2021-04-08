using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tests
{
    [Serializable]
    public class ItemData
    {
        public Texture Texture;
        public Color Color;
        public int Number;
    }

    public class Item : MonoBehaviour
    {
        public RawImage RawImage;
        public Image Image;
        public Text Number;
        public ItemData Data;

        public void Setup(ItemData itemData)
        {
            Data = itemData;
            Image.color = itemData.Color;
            RawImage.texture = itemData.Texture;
            Number.text = itemData.Number.ToString();
        }
    }
}