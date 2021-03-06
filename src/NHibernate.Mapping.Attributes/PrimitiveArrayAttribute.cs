// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.x
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class PrimitiveArrayAttribute : BaseAttribute
	{
		
		private string _access = null;
		
		private string _collectiontype = null;
		
		private int _batchsize = -1;
		
		private string _catalog = null;
		
		private bool _optimisticlockspecified;
		
		private string _table = null;
		
		private string _schema = null;
		
		private PrimitiveArrayOuterJoin _outerjoin = PrimitiveArrayOuterJoin.Unspecified;
		
		private bool _optimisticlock = true;
		
		private string _persister = null;
		
		private PrimitiveArrayFetch _fetch = PrimitiveArrayFetch.Unspecified;
		
		private string _node = null;
		
		private string _subselect = null;
		
		private bool _mutable = true;
		
		private string _name = null;
		
		private bool _mutablespecified;
		
		private string _check = null;
		
		private string _where = null;
		
		/// <summary> Default constructor (position=0) </summary>
		public PrimitiveArrayAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public PrimitiveArrayAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Access
		{
			get
			{
				return this._access;
			}
			set
			{
				this._access = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type AccessType
		{
			get
			{
				return System.Type.GetType( this.Access );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Access = value.FullName.Substring(7);
				else
					this.Access = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual string Table
		{
			get
			{
				return this._table;
			}
			set
			{
				this._table = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Schema
		{
			get
			{
				return this._schema;
			}
			set
			{
				this._schema = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Catalog
		{
			get
			{
				return this._catalog;
			}
			set
			{
				this._catalog = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Subselect
		{
			get
			{
				return this._subselect;
			}
			set
			{
				this._subselect = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Mutable
		{
			get
			{
				return this._mutable;
			}
			set
			{
				this._mutable = value;
				_mutablespecified = true;
			}
		}
		
		/// <summary> Tells if Mutable has been specified. </summary>
		public virtual bool MutableSpecified
		{
			get
			{
				return this._mutablespecified;
			}
		}
		
		/// <summary> </summary>
		public virtual string Where
		{
			get
			{
				return this._where;
			}
			set
			{
				this._where = value;
			}
		}
		
		/// <summary> </summary>
		public virtual int BatchSize
		{
			get
			{
				return this._batchsize;
			}
			set
			{
				this._batchsize = value;
			}
		}
		
		/// <summary> </summary>
		public virtual PrimitiveArrayOuterJoin OuterJoin
		{
			get
			{
				return this._outerjoin;
			}
			set
			{
				this._outerjoin = value;
			}
		}
		
		/// <summary> </summary>
		public virtual PrimitiveArrayFetch Fetch
		{
			get
			{
				return this._fetch;
			}
			set
			{
				this._fetch = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Persister
		{
			get
			{
				return this._persister;
			}
			set
			{
				this._persister = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type PersisterType
		{
			get
			{
				return System.Type.GetType( this.Persister );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Persister = value.FullName.Substring(7);
				else
					this.Persister = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual string CollectionType
		{
			get
			{
				return this._collectiontype;
			}
			set
			{
				this._collectiontype = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type CollectionTypeType
		{
			get
			{
				return System.Type.GetType( this.CollectionType );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.CollectionType = value.FullName.Substring(7);
				else
					this.CollectionType = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual string Check
		{
			get
			{
				return this._check;
			}
			set
			{
				this._check = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool OptimisticLock
		{
			get
			{
				return this._optimisticlock;
			}
			set
			{
				this._optimisticlock = value;
				_optimisticlockspecified = true;
			}
		}
		
		/// <summary> Tells if OptimisticLock has been specified. </summary>
		public virtual bool OptimisticLockSpecified
		{
			get
			{
				return this._optimisticlockspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual string Node
		{
			get
			{
				return this._node;
			}
			set
			{
				this._node = value;
			}
		}
	}
}
