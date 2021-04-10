using UnityEngine;

namespace Model
{
    public class BaseGrid : MonoBehaviour
    {
        #region Properties
        #endregion

        #region Members
        [SerializeField]
        protected BaseGridCell[,] gridCells;

        [SerializeField]
        protected Vector2Int size;

        [SerializeField]
        protected BaseGridCell prefab;

        [SerializeField]
        protected Vector2 origin;
        #endregion

        #region MonoBehaviour
        private void Awake() 
        {
            gridCells = new BaseGridCell[size.x, size.y];
            for (int posX = 0; posX < size.x; posX++) {
                for (int posY = 0; posY < size.y; posY++) {
                    gridCells[posX, posY] = Instantiate(prefab, getCellCenter(new Vector2Int(posX, posY)), Quaternion.identity, transform);
                    gridCells[posX, posY].gameObject.name = "Cell [" + posX + ", " + posY + "]";
                }
            }
        }
        #endregion
    
        private Vector3 getCellCenter(Vector2Int position)
        {
            return new Vector3(origin.x + (position.x *(prefab.Size.x + prefab.Offset)), 0, origin.y + (position.y *(prefab.Size.y + prefab.Offset)));
        }
    
    }
}