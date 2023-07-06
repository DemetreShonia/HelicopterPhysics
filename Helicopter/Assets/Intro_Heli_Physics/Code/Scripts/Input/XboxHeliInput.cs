using UnityEngine;

namespace Shonia
{
	public class XboxHeliInput : KeyBoardHeliInput
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

        #region Strings
        const string THROTTLE_UP = "XboxThrottleUp";
        const string THROTTLE_DOWN = "XboxThrottleDown";
        const string COLLECTIVE = "XboxCollective";
        const string PEDAL = "XboxPedal";
        const string CYCLIC_H = "XboxCyclicHorizontal";
        const string CYCLIC_V = "XboxCyclicVertical";
        #endregion

        #region Custom methods
        protected override void HandleThrottle()
        {
            _throttleInput = Input.GetAxis(THROTTLE_UP) + Input.GetAxis(THROTTLE_DOWN);
        }
        protected override void HandleCollective()
        {
            _collectiveInput = Input.GetAxis(COLLECTIVE);
        }
        protected override void HandleCyclic()
        {
            _cyclicInput.x = Input.GetAxis(CYCLIC_H);
            _cyclicInput.y = Input.GetAxis(CYCLIC_V);
        }
        protected override void HandlePedal()
        {
            _pedalInput = Input.GetAxis(PEDAL);
        }
        #endregion
    }
}
