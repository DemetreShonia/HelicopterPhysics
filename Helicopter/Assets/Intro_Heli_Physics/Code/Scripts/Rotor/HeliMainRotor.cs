using UnityEngine;

namespace Shonia
{
	public class HeliMainRotor : MonoBehaviour, IHeliRotor
	{
        #region Variables

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
        public void UpdateRotor(float dps)
        {
            //print("MAIN");
            //transform.rotation = Quaternion.Euler(0f, dps, 0f);
            transform.Rotate(Vector3.up, dps);
        }
        #endregion
    }
}
