using UnityEditor;

public class AssetImporterSample : AssetPostprocessor
{
    private void OnPreprocessAudio()
    {
        var audioImporter = (AudioImporter)assetImporter;
        if(audioImporter == null)
        {
            return;
        }

        audioImporter.forceToMono = true;
        audioImporter.SaveAndReimport();
    }
}
