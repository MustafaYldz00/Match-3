using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _heigth;
    [SerializeField] private GameObject[] _candiesPrefab;  

    private GameObject[,] _grid; 
    

    void Start()
    {
        CandyCreator();
    }

    public void CandyCreator()
    {
        _grid = new GameObject[_width, _heigth];

        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _heigth; y++)
            {
                int randomCandy = Random.Range(0, _candiesPrefab.Length);
                GameObject candyPrefab = _candiesPrefab[randomCandy];
                GameObject newCandy = Instantiate(candyPrefab, transform);
                newCandy.GetComponent<RectTransform>().localPosition = new Vector3(x*400,y*400,0);
                _grid[x, y] = newCandy;
                
            }

        }
    }
}
