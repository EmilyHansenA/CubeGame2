using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCubes : MonoBehaviour
{
    [SerializeField] private GameObject redCubes;
    [SerializeField] private GameObject blueCubes;

    GameObject[] redCubeArr;
    GameObject[] blueCubeArr;

    private string _redCubeTag = "redCube";
    private string _blueCubeTag = "blueCube";

    private int _redCubeCount;
    private int _blueCubeCount;

    public static int cubeBalance;

    private void Awake()
    {
        instCubes(blueCubes);
        instCubes(redCubes);

        redCubeArr = GameObject.FindGameObjectsWithTag(_redCubeTag);
        blueCubeArr = GameObject.FindGameObjectsWithTag(_blueCubeTag);

        _redCubeCount = redCubeArr.Length;
        _blueCubeCount = blueCubeArr.Length;

        cubeBalance = _redCubeCount + _blueCubeCount;
    }

    private void Update()
    {
        if (cubeBalance == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void instCubes(GameObject Cubes)
    {
        for (int i = 0; i < Random.Range(1, 5); i++)
        {
            Instantiate(Cubes, new Vector3(Random.Range(-2.8f, 2.8f), 0.5f, Random.Range(-2.5f, 2.5f)), Quaternion.identity);
        }
    }
}
