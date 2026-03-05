using UnityEngine;

public class Score : MonoBehaviour
{
    public float camConstant = 1.25f;
    public float CalculateScore(int woodChairs, int plasticChairs, int cameraTrades, int shadyCount)
    {
        float weightedSumChairs = 10f * woodChairs + 7f * plasticChairs;
        float shadyRatio = 1f / shadyCount;
        float onCameraNum = camConstant * cameraTrades;

        float finalScore = weightedSumChairs * shadyRatio * onCameraNum;
        
        return finalScore;
    }

    void Start()
    {
        float testScore = CalculateScore(3, 3, 3, 3);
        Debug.Log(testScore);
    }
}