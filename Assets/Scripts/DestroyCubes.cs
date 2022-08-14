using TMPro;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI redCount, blueCount;

    private int _redScore = 0;
    private int _blueScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("redCube") && gameObject.tag.Equals("redWall"))
        {
            _redScore++;
            CreateCubes.cubeBalance--;
            redCount.text = _redScore.ToString();

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("blueCube") && gameObject.tag.Equals("blueWall"))
        {
            _blueScore++;
            CreateCubes.cubeBalance--;
            blueCount.text = _blueScore.ToString();

            Destroy(collision.gameObject);
        }
    }
}