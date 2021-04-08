using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tests
{
    public class PooledScrollTest : MonoBehaviour
    {
        public ItemLayoutController LayoutController;
        public ItemGridController GridController;
        public InputField InputField;
        public int Count;
        public List<Color> Colors;
        public List<Texture> Textures;

        public void Start()
        {
            Apply();
        }

        public void Apply()
        {
            if (InputField != null && !string.IsNullOrEmpty(InputField.text))
            {
                int result;
                if (int.TryParse(InputField.text, out result))
                {
                    Count = result;
                }
            }

            List<ItemData> data = new List<ItemData>(Count);

            for (var i = 0; i < Count; i++)
            {
                // data.Add(new ItemData {Color = Colors[Random.Range(0, Colors.Count)], Number = i + 1}); // changed random access to indexed access
                data.Add(new ItemData {Texture = Textures[i % Textures.Count], Color = Colors[i % Colors.Count], Number = i});
            }

            if (LayoutController != null)
            {
                LayoutController.Initialize(data);
            }

            if (GridController != null)
            {
                GridController.Initialize(data);
            }
        }
    }
}