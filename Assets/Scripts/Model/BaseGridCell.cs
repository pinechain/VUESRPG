using UnityEngine;

using Utils;

namespace Model
{
    public abstract class BaseGridCell : MonoBehaviour
    {
        #region Properties
        public Prop Prop 
        {
            get => prop;
        }

        public Ground Ground
        {
            get => ground;
        }

        public Character Character
        {
            get => character;
        }

        public bool IsVisible
        {
            get => isVisible;
        }

        public Vector2 Size
        {
            get => new Vector2(transform.localScale.x, transform.localScale.z);
            private set => transform.localScale = new Vector3(value.x, 1, value.y);
        }

        public float Offset
        {
            get => transform.localScale.x * Constants.GRID_CELL_OFFSET_PERCENTAGE;
        }
        #endregion

        #region Members
        [SerializeField]
        protected Prop prop;

        [SerializeField]
        protected Ground ground;

        [SerializeField]
        protected Character character;

        [SerializeField]
        protected bool isVisible;
        #endregion
    }
}