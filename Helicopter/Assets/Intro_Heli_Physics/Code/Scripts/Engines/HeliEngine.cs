using UnityEngine;

namespace Shonia
{
	public class HeliEngine : MonoBehaviour
	{
		#region Variables
		public float maxHP = 140f; // horse power ACTUAL HELICOPTER!!
		public float maxRPM = 2700; // Revolution Per Min ACTUAL ENGINE!!!
		public float powerDelay = 2f;
		public AnimationCurve powerCurve = new AnimationCurve(new Keyframe(0f,0f), new Keyframe(1f,1f));
		//public AnimationCurve powerCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 1f); // THIS CAN BE DONE TOO

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
			// calculate horse power
			float wantedHP = powerCurve.Evaluate(throttleInput) * maxHP;
			_currentHP = Mathf.Lerp(_currentHP, wantedHP, Time.deltaTime * powerDelay);
            // calculate RPM
            float wantedRPM = throttleInput * maxRPM;
            _currentRPM = Mathf.Lerp(_currentRPM, wantedRPM, Time.deltaTime * powerDelay);
        }
        #endregion
    }
}
