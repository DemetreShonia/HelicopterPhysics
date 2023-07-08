using UnityEngine;

namespace Shonia
{
	public class HeliTailRotor : MonoBehaviour, IHeliRotor
	{

        #region Variables
        public Transform lRotor;
        public Transform rRotor;
        public float maxPitch = 45f;
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
            //print("TAIL");
            transform.Rotate(Vector3.right, dps * 1.5f * Time.deltaTime); // speed will be a bit faster

            //pitch the blasdes up and down
            if (lRotor && rRotor)
            {
                lRotor.localRotation = Quaternion.Euler(0, input.PedalInput * maxPitch, 0);
                rRotor.localRotation = Quaternion.Euler(0, -input.PedalInput * maxPitch, 0);
            }
        }
        #endregion
    }
}
