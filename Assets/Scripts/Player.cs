using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _playerTransform.position += Vector3.up * _speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            _playerTransform.position += Vector3.down * _speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            _playerTransform.position += Vector3.right * _speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            _playerTransform.position += Vector3.left * _speed * Time.deltaTime;
        }
    }

    public void PlantSeed ()
    {
        
    }
}
