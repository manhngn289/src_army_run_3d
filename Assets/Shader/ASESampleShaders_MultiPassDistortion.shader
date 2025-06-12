Shader "ASESampleShaders/MultiPassDistortion" {
	Properties {
		_FresnelScale ("FresnelScale", Float) = 1
		_FresnelPower ("FresnelPower", Float) = 1
		[HDR] _IntersectionColor ("Intersection Color", Vector) = (0.4338235,0.4377282,1,0)
		_FresnelScale2 ("FresnelScale2", Float) = 1
		_FresnelPower2 ("FresnelPower2", Float) = 1
		_FresnelColor2 ("FresnelColor2", Vector) = (0,0,0,0)
		_BottomMask ("BottomMask", Range(-1, 1)) = 0
		_IntersectionDistance ("IntersectionDistance", Float) = 0
		_IntersectionIntensity ("IntersectionIntensity", Range(-1, 1)) = 1
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