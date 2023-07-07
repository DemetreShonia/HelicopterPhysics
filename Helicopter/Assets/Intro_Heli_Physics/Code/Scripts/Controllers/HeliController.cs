using System.Collections.Generic;
using UnityEngine;

namespace Shonia
{
    [RequireComponent(typeof(InputController))]
    public class HeliController : BaseRBController
	{
        #region Variables
        [Header("Helicopter Properties")]
        public List<HeliEngine> engines = new List<HeliEngine>();

		InputController _input;
        #endregion

        #region Builtin Methods
        public override void Start()
        {
            base.Start();
            _input = GetComponent<InputController>();
        }

        void Update()
		{
		
		}
        #endregion

        #region Custom methods
        protected override void HandlePhysics()
        {
            if (_input != null)
			{
                HandleEngines();
                HandleCharacteristics();
            }
        }

        #endregion

        #region Helicopter Controler Methods

        protected virtual void HandleEngines()
        {
            for (int i = 0; i < engines.Count; i++)
            {
                engines[i].UpdateEngine(_input.StickyThrottleInput);
                float finalHP = engines[i].CurrentHP;
                print(finalHP);
            }
        }
        protected virtual void HandleCharacteristics()
        {

        }

        #endregion
    }
}
