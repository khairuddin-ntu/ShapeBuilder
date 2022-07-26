using System.Collections.Generic;
using UnityEngine;

public static class PointCalculator
{
    public static List<Vector3> Calculate2dPoints(Parameter parameter, int resolution)
    {
        List<Vector3> vectors = new();

        for (float u = parameter.Min; u <= parameter.Max; u += 1f / resolution)
        {
            // TODO: Replace with equation from user input
            vectors.Add(new Vector3(
                10 * u * Mathf.Cos(22 * Mathf.PI * u),
                10 * u * Mathf.Sin(22 * Mathf.PI * u),
                (10 * u) - 5
            ));
        }

        return vectors;
    }
}
