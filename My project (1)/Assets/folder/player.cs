
using UnityEngine;


    namespace aa 
{
    public class player : MonoBehaviour
    {
        #region ���
        [SerializeField , Tooltip("�]�t"),Range(0,20)    ]
        private float speed = 3.5f;
        [SerializeField]
        private float JH = 350;
        private Rigidbody2D rig;
        private Animator ani;

        #endregion
        #region �B��
        private void Awake()
        {
            ani = GetComponent<Animator>();
        }
        private void Start()
        {

        }
        private void Update()
        {

        }
        #endregion
        #region ���
        #endregion
        #region ���
        #endregion


    }

}

