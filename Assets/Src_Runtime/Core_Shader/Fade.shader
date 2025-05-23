Shader "Unlit/Fade"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _FadeSpeed ("Fade Speed", Float) = 1
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

            float _FadeSpeed;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                
                if(col.a > 0)
                {
                    // apply fog
                    // UNITY_APPLY_FOG(i.fogCoord, col);//目前不知道这个是干嘛的
                    float fade = 1.0 -(i.uv.y / _FadeSpeed);
                    return col*fade;
                }

                return fixed4(0,0,0,0);
            }
            ENDCG
        }
    }
}
