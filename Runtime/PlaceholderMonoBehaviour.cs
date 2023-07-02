using UnityEngine;

namespace PhantasmicDev.PackageTemplate
{
    /// <summary>
    /// This is a dummy script used for generating documentation.
    /// </summary>
    public class PlaceholderMonoBehaviour : MonoBehaviour
    {
        [SerializeField] private float m_Speed = 5f;

        [SerializeField] private string m_Message = "Hello, world!";

        [SerializeField] private Vector3 m_TargetPosition = Vector3.zero;

        /// <summary>
        /// Gets or sets the speed of the object.
        /// </summary>
        public float speed
        {
            get => m_Speed;
            set => m_Speed = Mathf.Clamp(value, 0f, 10f);
        }

        /// <summary>
        /// Is the object moving.
        /// </summary>
        public bool isMoving => Mathf.Abs(m_Speed) > 0f;

        /// <summary>
        /// Gets or sets the message to display.
        /// </summary>
        public string message
        {
            get => m_Message;
            set => m_Message = value;
        }

        /// <summary>
        /// Gets or sets the target position for movement.
        /// </summary>
        public Vector3 targetPosition
        {
            get => m_TargetPosition;
            set => m_TargetPosition = value;
        }

        /// <summary>
        /// Moves the object in a specific direction.
        /// </summary>
        /// <param name="direction">The direction to move in.</param>
        public void Move(Vector3 direction)
        {
            transform.Translate(direction.normalized * m_Speed * Time.deltaTime);
        }

        /// <summary>
        /// Rotates the object around a specified axis.
        /// </summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate by.</param>
        public void Rotate(Vector3 axis, float angle)
        {
            transform.Rotate(axis, angle * m_Speed * Time.deltaTime);
        }
    }
}
