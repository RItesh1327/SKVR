Shader "Custom/OilGrease" {
    Properties{
     _MainColor("Main Color", Color) = (1.000000,1.000000,1.000000,1.000000)
     _SpecularColor("Specular Color", Color) = (1.000000,1.000000,1.000000,1.000000)
     _Shininess("Shininess", Range(0.100000,1.000000)) = 0.500000
     _RimColor("Rim Color", Color) = (0.000000,0.000000,0.000000,1.000000)
     _RimPower("Rim Power", Range(0.100000,10.000000)) = 2.000000
     _DetailScale("Detail Scale", Range(0.100000,10.000000)) = 1.000000
     _DetailSpeed("Detail Speed", Range(0.100000,10.000000)) = 1.000000
     _RimThreshold("Rim Threshold", Range(0.100000,1.000000)) = 0.500000
    }
        SubShader{
         LOD 100
         Tags { "RenderType" = "Opaque" }
         Pass {
          Tags { "RenderType" = "Opaque" }
        CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag
        #pragma target 2.0
        #include "UnityCG.cginc"
        #pragma multi_compile_fog
        #define USING_FOG (defined(FOG_LINEAR) || defined(FOG_EXP) || defined(FOG_EXP2))

        // uniforms

        // vertex shader input data
        struct appdata {
          float3 pos : POSITION;
          half4 color : COLOR;
          UNITY_VERTEX_INPUT_INSTANCE_ID
        };

    // vertex-to-fragment interpolators
    struct v2f {
      fixed4 color : COLOR0;
      #if USING_FOG
        fixed fog : TEXCOORD0;
      #endif
      float4 pos : SV_POSITION;
      UNITY_VERTEX_OUTPUT_STEREO
    };

    // vertex shader
    v2f vert(appdata IN) {
      v2f o;
      UNITY_SETUP_INSTANCE_ID(IN);
      UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
      half4 color = IN.color;
      float3 eyePos = mul(UNITY_MATRIX_MV, float4(IN.pos,1)).xyz;
      half3 viewDir = 0.0;
      o.color = saturate(color);
      // compute texture coordinates
      // fog
      #if USING_FOG
        float fogCoord = length(eyePos.xyz); // radial fog distance
        UNITY_CALC_FOG_FACTOR_RAW(fogCoord);
        o.fog = saturate(unityFogFactor);
      #endif
        // transform position
        o.pos = UnityObjectToClipPos(IN.pos);
        return o;
      }

    // fragment shader
    fixed4 frag(v2f IN) : SV_Target {
      fixed4 col;
      col = IN.color;
      // fog
      #if USING_FOG
        col.rgb = lerp(unity_FogColor.rgb, col.rgb, IN.fog);
      #endif
      return col;
    }
    ENDCG
     }
    }
        Fallback "Diffuse"
}