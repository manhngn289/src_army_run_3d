Shader "FXIFIED/RimLight" {
	Properties {
		_ASEOutlineColor ("Outline Color", Vector) = (0,0,0,0)
		_ASEOutlineWidth ("Outline Width", Float) = 0
		_RimColor ("RimColor", Vector) = (0,0,0,0)
		_RimPower ("RimPower", Range(0, 10)) = 0
		[HideInInspector] _Normals ("Normals", 2D) = "bump" {}
		_MainTex ("MainTex", 2D) = "white" {}
		_ColorIntensity ("Color Intensity", Float) = 1
		_Color ("Color", Vector) = (1,1,1,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, float2(input.uv.x, input.uv.y)) * _Color;
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}