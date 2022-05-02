using UnityEngine;

public class MatrixTest : MonoBehaviour
{
    private void Start()
    {
        TranslationMatrixTest();
        //RotationMatrixTest();
        //ScalingMatrixTest();
    }

    private void TranslationMatrixTest()
    {
        var translationMatrix = new Matrix4x4(
            new Vector4(1, 0, 0, 0),
            new Vector4(0, 1, 0, 0),
            new Vector4(0, 0, 1, 0),
            new Vector4(3, 2, 1, 1)
        );

        var newPosition = translationMatrix.MultiplyPoint(transform.position);

        transform.position = newPosition;
    }

    private void RotationMatrixTest()
    {
        var rotation = Quaternion.Euler(0, 90, 0);
        var rotationMatrix = Matrix4x4.Rotate(rotation);
        var newPosition = rotationMatrix.MultiplyPoint(transform.position);
        transform.position = newPosition;
    }

    private void ScalingMatrixTest()
    {
        var scale = new Vector3(3, 2, 1);
        var scalingMatrix = Matrix4x4.Scale(scale);
        var newPosition = scalingMatrix.MultiplyPoint(transform.position);
        transform.position = newPosition;
    }
}
