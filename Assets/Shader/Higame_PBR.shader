Shader "Higame/PBR" {
	Properties {
		_BaseColor ("Base Color", 2D) = "black" {}
		_EmissiveMap ("Emissive Map", 2D) = "black" {}
		_EmissiveMix ("Emissive Mix", Range(0, 1)) = 0
		_BaseColorIntensity ("Base Color Intensity", Range(0, 1)) = 1
		_NormalMap ("Normal Map", 2D) = "bump" {}
		_RMMap ("RM Map", 2D) = "black" {}
		_IceColor ("Ice Color", Vector) = (1,1,1,0)
		_IceIntensity ("Ice Intensity", Range(0, 1)) = 0
		[HDR] _Rimlight ("Rimlight", Vector) = (0,0.8937449,1,0)
		[HDR] _RimPower ("Rim Power", Range(0, 5)) = 2.5
		_FlashColor ("Flash Color", Vector) = (1,1,1,0)
		_FlashIntensity1 ("Flash Intensity", Range(0, 1)) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
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
	Fallback "Diffuse"
}