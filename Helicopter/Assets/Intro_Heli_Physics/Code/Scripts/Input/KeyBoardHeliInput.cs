using UnityEngine;

namespace Shonia
{
    public class KeyBoardHeliInput : BaseHeliInput
    {
        #region Variables
        [Header("Heli Keyboard Inputs")]
        private float _throttleInput = 0f;
        private float _collectiveInput = 0f;
        private Vector2 _cyclicInput = Vector2.zero;
        private float _pedalInput = 0f;

        public float ThrottleInput { get => _throttleInput; set => _throttleInput = value; }
        public float CollectiveInput { get => _collectiveInput; set => _collectiveInput = value; }
        public Vector2 CyclicInput { get => _cyclicInput; set => _cyclicInput = value; }
        public float PedalInput { get => _pedalInput; set => _pedalInput = value; }
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
        }

        void HandleThrottle()
        {
            _throttleInput = Input.GetAxis(THROTTLE);
        }
        void HandleCollective()
        {
            _collectiveInput = Input.GetAxis(COLLECTIVE);
        }
        void HandleCyclic()
        {
            _cyclicInput.y = vertical;
            _cyclicInput.x = horizontal;
        }
        void HandlePedal()
        {
            PedalInput = Input.GetAxis(PEDAL);
        }
        #endregion
    }
}
