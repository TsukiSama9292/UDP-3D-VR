using UnityEngine;

namespace tsuki{

    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈生成點")]
        private Transform point;
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈速度"), Range(0,2000)]
        private int bulletSpeed = 1000;
        [SerializeField, Header("開槍特效")]
        private ParticleSystem psFire;
        [SerializeField, Header("開槍音效")]
        private AudioClip soundFire;
        private AudioSource aud;
        
        private void Awake(){
            aud = GetComponent<AudioSource>();
        }
        /// <summary>
        /// 發射子彈
        /// </sumary>
        public void Fire()
        {
            GameObject temp = Instantiate(prefabBullet, point.position , Quaternion.identity);
            temp.GetComponent<Rigidbody>().AddForce(point.forward * bulletSpeed);
        }
    }
}

