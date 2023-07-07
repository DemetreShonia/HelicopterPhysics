using UnityEngine;

namespace Shonia
{
	public class HeliTailRotor : MonoBehaviour, IHeliRotor
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
            //print("TAIL");
            transform.Rotate(Vector3.right, dps * 1.5f); // speed will be a bit faster
        }
        #endregion
    }
}
