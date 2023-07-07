using UnityEngine;

namespace Shonia
{
	public class HeliEngine : MonoBehaviour
	{
		#region Variables
		public float maxHP = 140f; // horse power ACTUAL HELICOPTER!!
		public float maxRPM = 2700; // Revolution Per Min ACTUAL ENGINE!!!
		public float powerDelat = 2f;

		#endregion

		#region Properties
		float _currentHP;
		float _currentRPM;

		public float CurrentHP => _currentHP;
        public float CurrentRPM => _currentRPM;
        #endregion

        #region Builtin Methods
        void Start()
		{
		
		}
		
		
		#endregion
		
		#region Custom methods
		public void UpdateEngine(float throttleInput)
		{
			//Debug.Log(throttleInput);
		}
		#endregion
	}
}
