# Interactive Stylized Water
## Introduction
Interactive Stylized Water is a Unity 2022.1.0 project initially created as a URP shader using Unity Shader Graph. The "Test Scene" also includes a Water Caustics material and Underwater Effect to enhance the underwater feeling.

![Interactivity](https://user-images.githubusercontent.com/47041584/234895511-efc0aa3b-18c2-4ac4-bdc6-3be0818d3813.png)

![Underwater](https://user-images.githubusercontent.com/47041584/234895528-dbe9824a-2829-4d85-a312-81e3bad1d13b.png)

## Features

* **Color Control**: The water shader allows you to control the color and transparency of the shallow and deep parts of the water.
* **Foam Generation**: There is foam at the intersection edges of objects and water. You can control the foam color, amount, and cutoff limit. 
* **Wave**:  You can control the water’s wave amplitude, frequency, and speed. It is connected to the vertex position node.
* **Normal**: There is a normal generated from noise texture. You can control the surface scale, normal strength, and water speed here. It can be replaced easily with the custom normal map.
* **Refraction**: The refraction group adds more realism to the water by creating fake distortion on the underwater parts of objects that are inside the water.
* **Interactivity**: Using render texture allows the water to be an active element in the gameplay rather than a decoration. It provides ripple effects occur on the surface of water  while the interactor object is moving in water.
* **Water Caustics**: “Underwater caustics shader” generates caustics effect by using a render target. It is used together with underwater post-processing effects to enhance the underwater feeling.

![WaterSettings](https://user-images.githubusercontent.com/47041584/234895473-386908dc-4d02-4b87-b270-0b0b1089892e.png)

![CausticsSettings](https://user-images.githubusercontent.com/47041584/234895488-7cff4f65-dbd1-4b83-b9b6-8620fa69cc35.png)

## Version Information and Requirements
* Unity Version: 2022.1.0
* Universal Render Pipeline (URP)
* Compatible with Unity 2019.3 and above

## Usage 
To use the Interactive Stylized Water Shader and its other components, follow these steps:

1. Open the Unity project.
2. Make sure the project is set to use the Universal Render Pipeline (URP) template.
3. Make sure the “depth texture” and “opaque texture” options are enabled in the URP settings.
4. Create a new scene or open the provided "TestScene" scene.
5. For new scenes, create a plane or a cube (not recommended for proper use of wave feature) for the water, and apply the WaterShader material to it. You can also import your custom mesh.
5. For the interactivity, add a collider to the water object with "Is Trigger" checked.
6. Create an object to interact with the water, and add a collider and rigidbody to it.
7. To use the ripple effect, make it a child to the interactor object. You can also create your own ripple effect. If you are using your own effect, note that the blue channel is used in the shader for the effect.
8. Create a new “Orthographic Camera” and make sure its size is set to cover the entire water surface. Set the background type to solid color and set the color to black. Attach the “Interaction.cs” script to it. Set the “Output Texture” of the camera and “Render Texture” fields to the render texture you create, and set the Interactor field to the object you created as an interactor object. 
9. Set the ripple particles layer to a new layer you want. In your “Orthographic Camera” only select this new layer on culling mask settings. However, in your “Main Camera” deselect this layer.

## Additional Scripts
* Interaction.cs
* RippleTrigger.cs
* UnderwaterTrigger.cs




