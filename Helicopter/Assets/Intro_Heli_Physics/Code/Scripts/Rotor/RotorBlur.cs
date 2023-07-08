using System.Collections.Generic;
using UnityEngine;

namespace Shonia
{
    public class RotorBlur : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Rotor Blur Properties")]
        public float maxDps = 1000f; // degrees per second
        public List<GameObject> blades = new List<GameObject>();
        public GameObject blurGeo;

        public List<Texture2D> blurTextures = new List<Texture2D>();
        public Material blurMaterial;
        #endregion

        #region Builtin Methods
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion

        #region Interface methods
        public void UpdateRotor(float dps, InputController input)
        {
            //print("BLURRING");
            float normalizedDPS = Mathf.InverseLerp(0f, maxDps, dps);
            print(dps);
            int blurTextID = Mathf.FloorToInt(normalizedDPS * blurTextures.Count -1);
            blurTextID = Mathf.Clamp(blurTextID, 0, blurTextures.Count - 1);
            if(blurMaterial && blurTextures.Count > 0 )
            {
                blurMaterial.SetTexture("_MainTex", blurTextures[blurTextID]);
            }
            if(blurTextID > 2 && blades.Count > 0 )
            {
                foreach (var blade in blades)
                {
                    blade.SetActive(false);
                }
            }
            else
            {
                foreach (var blade in blades)
                {
                    blade.SetActive(true);
                }
            }
        }
        #endregion
    }
}
