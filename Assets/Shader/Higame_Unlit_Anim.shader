Shader "Higame/Unlit_Anim" {
	Properties {
		_BaseColor ("Base Color", 2D) = "white" {}
		_IceColor ("Ice Color", Vector) = (1,1,1,0)
		_EmissiveMap ("Emissive Map", 2D) = "black" {}
		_IceIntensity ("Ice Intensity", Range(0, 1)) = 0
		[HDR] _Rimlight ("Rimlight", Vector) = (0,0.8937449,1,0)
		[HDR] _RimPower ("Rim Power", Range(0, 5)) = 2.5
		_FlashColor ("Flash Color", Vector) = (1,1,1,0)
		_FlashIntensity1 ("Flash Intensity", Range(0, 1)) = 0
		_GrayIntensity ("Gray Intensity", Range(0, 1)) = 0
		_GrayTexture ("GrayTexture", 2D) = "white" {}
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[PerRendererData] _AnimTimeInfo ("Animation Time Info", Vector) = (0,0,0,0)
		[PerRendererData] _AnimTextures ("Animation Textures", 2DArray) = "black" {}
		[PerRendererData] _AnimTextureIndex ("Animation Texture Index", Float) = -1
		[PerRendererData] _AnimInfo ("Animation Info", Vector) = (0,0,0,0)
		[PerRendererData] _AnimScalar ("Animation Scalar", Vector) = (1,1,1,0)
		[PerRendererData] _CrossfadeAnimTextureIndex ("Crossfade Texture Index", Float) = -1
		[PerRendererData] _CrossfadeAnimInfo ("Crossfade Animation Info", Vector) = (0,0,0,0)
		[PerRendererData] _CrossfadeAnimScalar ("Crossfade Animation Scalar", Vector) = (1,1,1,0)
		[PerRendererData] _CrossfadeStartTime ("Crossfade Start Time", Float) = -1
		[PerRendererData] _CrossfadeEndTime ("Crossfade End Time", Float) = -1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_MatrixMVP;

			struct Vertex_Stage_Input
			{
				float3 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixMVP, float4(input.pos, 1.0));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
}