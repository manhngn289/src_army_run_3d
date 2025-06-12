Shader "Smoke" {
	Properties {
		_ToonRamp ("Toon Ramp", 2D) = "white" {}
		[Header(Main)] [NoScaleOffset] _Main ("Main", 2D) = "white" {}
		_Tiling ("Tiling", Vector) = (1,1,0,0)
		_Offset ("Offset", Vector) = (0,0,0,0)
		_Scroll ("Scroll", Vector) = (1,0,0,0)
		[Header(LimitUV)] _LimitUVRange ("LimitUVRange", Vector) = (0,1,0,1)
		[Toggle] _LimitUV ("LimitUV", Float) = 0
		[Header(StretchUV)] _StretchUVDes ("StretchUVDes", Vector) = (0,0,0,0)
		_StretchMultiplier ("StretchMultiplier", Vector) = (0,0,0,0)
		[Toggle] _Stretch ("Stretch", Float) = 0
		[Header(Mask)] [NoScaleOffset] _NoiseMask ("NoiseMask", 2D) = "white" {}
		[Toggle] _Mask ("Mask", Float) = 1
		_MaskScroll ("MaskScroll", Vector) = (0,0,0,0)
		_MaskTiling ("MaskTiling", Vector) = (0,0,0,0)
		_MaskOffset ("MaskOffset", Vector) = (0,0,0,0)
		_Feather ("Feather", Range(0, 1)) = 0
		[Header(StaticMask)] _StaticMask ("StaticMask", 2D) = "white" {}
		_SmoothStep ("SmoothStep", Vector) = (0,1,0,0)
		[HDR] _FireColor ("FireColor", Vector) = (0,0,0,0)
		_FireTexture ("FireTexture", 2D) = "white" {}
		_Feather1 ("Feather", Range(0, 1)) = 0
		[HideInInspector] _texcoord2 ("", 2D) = "white" {}
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
	//CustomEditor "ASEMaterialInspector"
}