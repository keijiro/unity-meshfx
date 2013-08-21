Shader "Custom/Skeleton Transparent" {
	Properties {
		_Color ("Main Color (RGBA)", Color) = (1, 1, 1, 0.5)
        _Offset ("Vertex Offset", float) = 0.0
	}
	SubShader {
        Tags { "Queue" = "Transparent" }
        Pass {
            Blend SrcAlpha OneMinusSrcAlpha
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            
            half4 _Color;
            float _Offset;
            
            struct v2f {
                float4 pos : SV_POSITION;
            };
            
            v2f vert (appdata_base v)
            {
                v2f o;
                float4 pos = v.vertex;
//                pos.xyz += v.normal.xyz * _Offset;
                o.pos = mul (UNITY_MATRIX_MVP, pos);
                return o;
            }
            
            half4 frag (v2f i) : COLOR
            {
                return _Color;
            }
            
            ENDCG
        }
	} 
	FallBack Off
}