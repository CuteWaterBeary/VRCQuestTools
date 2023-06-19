## Usage

Select your avatar from a scene, then use *VRCQuestTools* menu item from the menu bar. Some functions are automatically enabled.

## Features

### Convert Avatar for Quest

Convert a PC avatar to be ready to upload for Quest by automating following operations.


VRCQuestTools doesn't make any changes to the original avatar, so you can use the tool in existing projects as is.

- Duplicate avatars and materials
- Change shader to VRChat/Mobile/Toon Lit
- Generate textures that reflect the original material's Color and Emission
- Remove unusable components such as DynamicBone and Cloth.
- Duplicate and convert animations with Animator Controller when material change animations exist.


### Remove Missing Components

Remove "Missing" components from a GameObject and its descendants.
You will often need to use this when Dynamic Bone asset is missing in your project.

### Remove PhysBones

Select and remove Avatar Dynamics components (e.g. PhysBone) from your avatar.


### Remove Unsupported Components

Remove components that cannot be used in avatars for Quest, such as DynamicBone and Cloth.

### Copy Weighted BlendShapes from one Avatar to Another

Copy BlendShape (Shape key) weights from a Skinned Mesh Renderer to another Skinned Mesh Renderer.
You will often use when PC version and Quest version use different models and need to have same BlendShape weights.

### Generate Metallic Smoothness Map

Generates a Metallic Smoothness map from a Metallic map or a Smoothness/Roughness map.
The generated textures can be used in VRChat/Mobile/Standard Lite shaders.


### Auto Remove Vertex Colors

Automatically remove vertex colors from scene's avatars. By using this, this would fix an issue where main textures are not correctly applied in some avatars.

![VertexColorRemover](.images/VertexColorRemover.png)

### Unity Settings for Quest

Enable useful settings of Unity like changing which image compression algorithm to use.

### Automated Scene Validation

Displays a warning if the avatar in the Scene is in a state where it cannot be uploaded.


## Paid Features

https://kurotu.booth.pm/items/3375621

### FinalIK
FinalIK was not a target component for deletion in the standard function of VRCQuestTools, but it is now a target for deletion after installation.

### VirtualLens2
When converting avatars, GameObjects such as drone lenses that are not needed on the Quest side will be excluded from uploading.
