To enable the support for instanced indirect by Vegetation Studio or procedural instancing by Nature Renderer please follow the below steps. 
These steps will overwrite our shaders.

You must have Vegetation Studio version 1.4.5 or newer. Vegetation Studio versions older than 1.4.5 are not compatible with this package.

--------------------------------------------------------------------------------

Vegetation Studio - HOW TO USE:
1. Import the SRP template from "ANGRY MESH > Nature Pack - PBR Rocks > SRP" folder - Please ignore this step if you don't use an HDRP or URP template.
2. Import the Vegetation Studio or Vegetation Studio Pro package. 
3. Import the afferent package from the "ANGRY MESH > Nature Pack - PBR Rocks > Third-Party Support > Vegetation Studio" folder. 
	- For Unity Standard RP, please use the VS Standard RP.unitypackage

	- For Unity 2021.2.0, HDRP version 12.1.0 or above - You need to use VS HDRP 12.1.0.unitypackage
	- For Unity 2020.2.0, HDRP version 10.2.2 or above - You need to use VS HDRP 10.2.2.unitypackage
	- For Unity 2019.4.0, HDRP version 7.2.1 or above - You need to use VS HDRP 7.2.1.unitypackage

	- For Unity 2021.2.0, URP version 12.1.0 or above - You need to use VS URP 12.1.0.unitypackage
	- For Unity 2020.2.0, URP version 10.2.2 or above - You need to use VS URP 10.2.2.unitypackage
	- For Unity 2019.4.0, URP version 7.2.1 or above - You need to use VS URP 7.2.1.unitypackage

Note: 
- You must keep VS_indirect and VS_IndirectHD in the same folder with our shaders. 
- We kept old VS prefabs in the "Legacy Prefabs" folder to don't destroy the projects for users that used VS before this update. 
Starting with version 2.0 you can use the prefabs from the "ANGRY MESH > Nature Pack - PBR Rocks > Prefabs" folder because now our shaders are overwritten when you follow the above steps. 
- You can go back to the default shaders (without support for VS or NR), using the package from the "ANGRY MESH > Nature Pack - PBR Rocks > Third-Party Support > Backup Shaders" folder 

--------------------------------------------------------------------------------

Nature Renderer - HOW TO USE:
1. Import the SRP template from "ANGRY MESH > Nature Pack - PBR Rocks > SRP" folder - Please ignore this step if you don't use an HDRP or URP template.
2. Import the Nature Renderer package.
3. Import the afferent package from the "ANGRY MESH > Nature Pack - PBR Rocks > Third-Party Support > Nature Renderer" folder. 
	- For Unity Standard RP, please use the NR Standard RP.unitypackage

	- For Unity 2020.2.0, HDRP version 10.2.2 or above - You need to use NR HDRP 10.2.2.unitypackage
	- For Unity 2019.4.0, HDRP version 7.2.1 or above - You need to use NR HDRP 7.2.1.unitypackage

	- For Unity 2020.2.0, URP version 10.2.2 or above - You need to use NR URP 10.2.2.unitypackage
	- For Unity 2019.4.0, URP version 7.2.1 or above - You need to use NR URP 7.2.1.unitypackage

Note: 
- You must keep "Nature Renderer.cginc" in the "Assets/Visual Design Cafe/Nature Shaders/Common/Nodes/Integrations" folder. 
- You can go back to the default shaders (without support for VS or NR), using the package from the "ANGRY MESH > Nature Pack - PBR Rocks > Third-Party Support > Backup Shaders" folder 
