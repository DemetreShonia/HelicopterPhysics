using UnityEngine;

namespace Shonia
{
	public interface IHeliRotor 
	{
        #region Methods
        void UpdateRotor(float dps, InputController input); //degrees per second
        #endregion
    }
}