using UnityEngine;

namespace Shonia
{
	public class HeliMainRotor : MonoBehaviour, IHeliRotor
    {
        #region Variables
        [Header("Main Rotor Properties")]
        public Transform lRotor;
        public Transform rRotor;
        public float maxPitch = 35f;

        #endregion

        #region Builtin Methods
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion

        #region Custom methods

        #endregion

        #region Interface Methods
        public void UpdateRotor(float dps, InputController input)
        {
            //print("MAIN");
            //transform.rotation = Quaternion.Euler(0f, dps, 0f);
            transform.Rotate(Vector3.up, dps);

            //pitch the blasdes up and down
            if (lRotor && rRotor)
            {
                lRotor.localRotation = Quaternion.Euler(-input.StickyCollectiveInput * maxPitch, 0, 0);
                rRotor.localRotation = Quaternion.Euler(input.StickyCollectiveInput * maxPitch, 0, 0);
            }
        }
        #endregion
    }
}
