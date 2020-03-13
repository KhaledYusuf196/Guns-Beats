Shader "Custom/ForceField"
{
	Properties{
		_Offset("Offset Color", Color) = (0, 0, 0, 0.5)
		_Color("Corner Color", Color) = (0, 0, 0, 0.5)
		_ColorX("Border Color X", Color) = (0, 0, 0, 0.5)
		_ColorY("Border Color Y", Color) = (0, 0, 0, 0.5)

		_Intensity("Offset Intensity", Range(0,1)) = 0.5
		_Border("Corner", Range(0,1)) = 0.5
		_BorderX("Border X", Range(0,0.5)) = 0.5
		_BorderY("Border Y", Range(0,0.5)) = 0.5
	}

		SubShader{
			Tags{ "RenderType" = "Transparent" "Queue" = "Transparent"}

			Blend SrcAlpha OneMinusSrcAlpha
			ZWrite off

			Pass{
				CGPROGRAM

				#include "UnityCG.cginc"

				#pragma vertex vert
				#pragma fragment frag

				fixed4 _Offset;
				fixed4 _Color;
				fixed4 _ColorX;
				fixed4 _ColorY;
				float1 _Intensity;
				float1 _Border;
				float1 _BorderX;
				float1 _BorderY;

				struct appdata {
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f {
					float4 position : SV_POSITION;
					float2 uv : TEXCOORD0;
				};

				v2f vert(appdata v) {
					v2f o;
					o.position = UnityObjectToClipPos(v.vertex);
					o.uv = v.uv;
					return o;
				}

				fixed4 frag(v2f i) : SV_TARGET{
					float1 distanceX = pow(i.uv.x - 0.5, 2);
					float1 distanceY = pow(i.uv.y - 0.5, 2);
					float1 distance = distanceX + distanceY;
					fixed4 colX = _ColorX;
					fixed4 colY = _ColorY;
					fixed4 col = _Color;
					if(distanceX < _BorderX) {
						colX *= distanceX / _BorderX;
					}
					if (distanceY < _BorderY) {
						colY *= distanceY / _BorderY;
					}
					if (distance < _Border) {
						col *= distance / _Border;
					}
					col += colX + colY + _Offset * _Intensity;
					col.a = _Offset.a + colX.a * distanceX + colY.a * distanceY;
					return col;
				}

				ENDCG
			}
	}
}
