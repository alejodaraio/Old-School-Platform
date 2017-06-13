using UnityEngine;

namespace gamesvsalex
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Animator))]

    public class PlayerController : PlayerMotor
    {
        public bool isGrounded = true;

        private void Awake()
        {
            m_rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            InputsController();
        }

        void FixedUpdate()
        {
            Move();
            isGrounded = isGround();
        }

        void InputsController()
        {
            if (Input.GetButtonDown(GameInputs.VERTICAL) && isGrounded)
            {
                Jump();
                isGrounded = false;
            }
        }
    }
}