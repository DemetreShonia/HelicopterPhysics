using System;
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

        [Header("Helicopter Rotors")]
        public HeliRotorController _rotorCtrl;
		InputController _input;
        HeliCharacteristics _characteristics;
        #endregion

        #region Builtin Methods
        public override void Start()
        {
            base.Start();
            _input = GetComponent<InputController>();
            _characteristics = GetComponent<HeliCharacteristics>();
        }

        #endregion

        #region Custom methods
        protected override void HandlePhysics()
        {
            if (_input != null)
			{
                HandleEngines();
                HandleRotors();
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
            }
        }

        protected virtual void HandleRotors()
        {
            if(_rotorCtrl != null && engines.Count > 0)
            {
                _rotorCtrl.UpdateRotors(_input, engines[0].CurrentRPM);
            }
        }
        protected virtual void HandleCharacteristics()
        {
            if (_characteristics)
            {
                _characteristics.UpdateCharacteristics(rb, _input);
            }
        }

        #endregion
    }
}
