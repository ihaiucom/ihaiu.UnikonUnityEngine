using System;

namespace UnityEngine
{
	public struct CombineInstance
	{
		private int m_MeshInstanceID;

		private int m_SubMeshIndex;

		private Matrix4x4 m_Transform;

		private Vector4 m_LightmapScaleOffset;

		private Vector4 m_RealtimeLightmapScaleOffset;

		public Mesh mesh
		{
            get;
            set;
		}

		public int subMeshIndex
		{
			get
			{
				return this.m_SubMeshIndex;
			}
			set
			{
				this.m_SubMeshIndex = value;
			}
		}

		public Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			set
			{
				this.m_Transform = value;
			}
		}

		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.m_LightmapScaleOffset;
			}
			set
			{
				this.m_LightmapScaleOffset = value;
			}
		}

		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.m_RealtimeLightmapScaleOffset;
			}
			set
			{
				this.m_RealtimeLightmapScaleOffset = value;
			}
		}
	}
}
