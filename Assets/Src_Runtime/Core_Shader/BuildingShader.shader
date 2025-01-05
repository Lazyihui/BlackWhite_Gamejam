Shader "Unlit/BuildingShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        // _Color ("Color", Color) = (1,1,1,1)
        // _BuildingColor ("Building Color", Color) = (1,1,1,1)
        // _BuildingOffset ("Building Offset", Float) = 0.0
        _BuildingOffset ("Building Offset", Float) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            float _BuildingOffset;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                // 输出的uv存储在o.uv值中，z存储用于Clip的参数值
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);

                o.uv.y = o.uv.y - _BuildingOffset;

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                clip(i.uv.y);
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv.xy);
                return col;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
