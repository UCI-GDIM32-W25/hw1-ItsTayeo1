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
        _numSeedsLeft = _numSeeds;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        PlantSeed ();
        

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

    private void PrintMessage ()
    {
        Debug.Log("hello world");
    }

    public void PlantSeed ()
    {
        while (_numSeedsLeft > 0)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                PrintMessage();
                Instantiate(_plantPrefab);
                _numSeedsPlanted++;
                _numSeeds--;
            }
        }
    }

    
}
