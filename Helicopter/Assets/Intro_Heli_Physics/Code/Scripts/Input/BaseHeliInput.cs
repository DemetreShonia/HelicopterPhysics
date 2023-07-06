using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shonia
{
    public class BaseHeliInput : MonoBehaviour
    {
        #region Variables
        [Header("Base Input Properties")]
        [SerializeField] float _vertical = 0f;
        [SerializeField] float _horizontal = 0f;

        #region Strings
        const string VERTICAL = "Vertical";
        const string HORIZONTAL = "Horizontal";

        #endregion

        #endregion

        #region BuiltIn Methods
        void Update()
        {
            HandleInputs();
        }
        #endregion
        #region Custom Methods
        protected virtual void HandleInputs() 
        {
            _vertical = Input.GetAxis(VERTICAL);
            _horizontal = Input.GetAxis(HORIZONTAL);
        }
        #endregion
    } 
}
