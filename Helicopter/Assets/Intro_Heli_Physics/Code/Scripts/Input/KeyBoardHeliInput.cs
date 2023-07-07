using UnityEngine;

namespace Shonia
{
    public class KeyBoardHeliInput : BaseHeliInput
    {
        #region Variables
        [Header("Heli Keyboard Inputs")]
        protected float _throttleInput = 0f;
        protected float _collectiveInput = 0f;
        protected Vector2 _cyclicInput = Vector2.zero;
        protected float _pedalInput = 0f;

        public float ThrottleInput => _throttleInput;
        public float CollectiveInput => _collectiveInput;
        public Vector2 CyclicInput => _cyclicInput;
        public float PedalInput => _pedalInput;
        #endregion

        #region Builtin Methods

        #endregion


        #region Strings
        const string THROTTLE = "Throttle";
        const string COLLECTIVE = "Collective";
        const string PEDAL = "Pedal";
        #endregion

        #region Custom methods

        protected override void HandleInputs()
        {
            base.HandleInputs();

            HandleThrottle();
            HandleCollective();
            HandleCyclic();
            HandlePedal();
            ClampInputs();
        }

        protected virtual void HandleThrottle()
        {
            _throttleInput = Input.GetAxis(THROTTLE);
        }
        protected virtual void HandleCollective()
        {
            _collectiveInput = Input.GetAxis(COLLECTIVE);
        }
        protected virtual void HandleCyclic()
        {
            _cyclicInput.y = vertical;
            _cyclicInput.x = horizontal;
        }
        protected virtual void HandlePedal()
        {
            _pedalInput = Input.GetAxis(PEDAL);
        }

        protected void ClampInputs()
        {
            _throttleInput = Mathf.Clamp(_throttleInput, -1f, 1f);
            _collectiveInput = Mathf.Clamp(_collectiveInput, -1f, 1f);
            _pedalInput = Mathf.Clamp(_pedalInput, -1f, 1f);
            _cyclicInput = Vector2.ClampMagnitude(_cyclicInput, 1f);
        }
        #endregion
    }
}
