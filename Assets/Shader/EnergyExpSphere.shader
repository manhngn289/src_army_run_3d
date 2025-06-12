Shader "EnergyExpSphere" {
	Properties {
		_TintColor ("Tint Color", Vector) = (0.5,0.5,0.5,0.5)
		_MainTex ("Particle Texture", 2D) = "white" {}
		_InvFade ("Soft Particles Factor", Range(0.01, 3)) = 1
		[Header(Main)] [NoScaleOffset] _Main ("Main", 2D) = "white" {}
		_Tiling ("Tiling", Vector) = (1,1,0,0)
		_Offset ("Offset", Vector) = (0,0,0,0)
		_Scroll ("Scroll", Vector) = (1,0,0,0)
		[Header(LimitUV)] _LimitUVRange ("LimitUVRange", Vector) = (0,1,0,1)
		[Toggle] _LimitUV ("LimitUV", Float) = 1
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
		_FresnelScale ("FresnelScale", Float) = 1
		_TextureSample0 ("Texture Sample 0", 2D) = "white" {}
		[HideInInspector] _texcoord ("", 2D) = "white" {}
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

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, float2(input.uv.x, input.uv.y));
			}

			ENDHLSL
		}
	}
}