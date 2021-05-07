using UnityEditor;
using UnityEngine;

namespace Ferdi{
public class VFX_Menu : EditorWindow{

    [MenuItem("Assets/Create/Visual Effects/Ferdi/PointCloud")]
    public static void ImportPointCloud(){
    	string NewAsset = AssetDatabase.GenerateUniqueAssetPath("Assets/VFX/PointCloud.vfx");
        AssetDatabase.CopyAsset("Packages/com.ferdi.vfx/VFX/PointCloud.vfx", NewAsset);
        SelectNewAsset(NewAsset);
    }

    [MenuItem("Assets/Create/Visual Effects/Ferdi/PointCloud_Swarm")]
    public static void ImportPointCloud_Swarm(){
    	string NewAsset = AssetDatabase.GenerateUniqueAssetPath("Assets/VFX/PointCloud_Swarm.vfx");
        AssetDatabase.CopyAsset("Packages/com.ferdi.vfx/VFX/PointCloud_Swarm.vfx", NewAsset);
        SelectNewAsset(NewAsset);
    }

    public static void SelectNewAsset(string NewAsset){
        AssetDatabase.Refresh();
        Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(NewAsset);
    }
}
}