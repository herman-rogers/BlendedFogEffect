# BlendedFogEffect

![alt tag](https://raw.githubusercontent.com/herman-rogers/BlendedFogEffect/master/BlendedFogEffect.png)

## Fogging Issues in Unity3D

This project shows an example of how to get a smooth fog effect in Unity 3D by blending the background fog with the skybox colors.

From the image above the left is Unity's standard fog effect which clips in the scene objects which is especially noticeable on large / tall objects. This happens because the skybox color is different than the fog color causing it to have a harsh clipping line. There is also the added downside that you lose clarity / details of the Skybox if you use the Global Fog Shader image effect.

The right image is using a custom shader (created by Keijiro - link below) which takes the HDR skybox color (and other attributes) and blends the skybox smoothly with the fog causing a nice and smooth fade effect. The only downside to this approach is that a highly detailed skybox which show through objects in your scene - making it look more like a transparency effect than a fogging effect. To get around this, this project uses fairly simple skybox textures with some, but not a great amount, of detail. This allows us to not have an overly apparent transparency look and also allows us to blend multiple colors while letting some Skybox detail show through.

## Projects Used

Everything in this project was compiled by trial and error from multiple sources around the web. Essentially it boils down to tweaking your fogging settings, having a Skybox/Fog blending shader, and some simple skybox textures. Here are a list of resources used:

##### Note: I've modified the Kino fog shader to work with Alpha cutout shaders and forward rendering (required for our mobile game). AFAIK these have not been added to the main Kino fog shader.

#### Skybox Shader
[Kino Fog Github Source](https://github.com/keijiro/KinoFog)

#### Skybox Cartoon Textures
[Farland Skies Cloud Crown Textures](https://www.assetstore.unity3d.com/en/#!/content/60004)

## Roadmap

#### Mobile / 6-Sided Skybox Support

Currently the skybox shader only supports Unity's HDR skyboxes. It will not work with a 6-sided texture skybox - this means there may be some performance issues with this on mobile. We plan to have this up and running depending on how hard this hits the mobile platforms.
