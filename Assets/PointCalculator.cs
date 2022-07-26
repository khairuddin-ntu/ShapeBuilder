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
                (27 * u) - 9,
                Mathf.Cos(18 * Mathf.PI * u),
                0
            ));
        }

        return vectors;
    }
}
