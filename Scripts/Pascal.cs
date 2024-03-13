using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class Pascal : MonoBehaviour
{
    public int numRows; // Количество строк в треугольнике Паскаля
    public Text triangle;

    void Start()
    {
        GeneratePascalTriangle(numRows);
    }

    void GeneratePascalTriangle(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int coef = BinomialCoefficient(i, j);
                Debug.Log(coef + " ");
                triangle.text += coef + " ";
            }
            Debug.Log("\n");
            triangle.text += "\n";
        }
    }

    int BinomialCoefficient(int n, int k)
    {
        if (k > n - k)
            k = n - k;
        int c = 1;
        for (int i = 0; i < k; ++i)
        {
            c *= (n - i);
            c /= (i + 1);
        }
        return c;
    }
}