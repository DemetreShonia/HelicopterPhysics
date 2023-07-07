using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace Shonia
{
	public class HeliRotorController : MonoBehaviour
	{
		#region Variables
		List<IHeliRotor> _rotors;
		#endregion
		
		#region Builtin Methods
		void Start()
		{
            _rotors = GetComponentsInChildren<IHeliRotor>().ToList<IHeliRotor>();
        }
		
		#endregion
		
		#region Custom methods
		public void UpdateRotors(InputController input, float currentRPMs)
		{
			//print("UPDATING ROTOR");
			//degrees per second calculation

			float dps = (currentRPMs * 360f) / 60f * Time.deltaTime;
			// update or rotors
			foreach (var rotor in _rotors)
			{
				rotor.UpdateRotor(dps);
			}
		}
		#endregion
	}
}
