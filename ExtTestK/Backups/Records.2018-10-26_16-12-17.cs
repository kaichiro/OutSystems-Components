using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtTestK {

	/// <summary>
	/// Structure <code>RCTuboRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTuboRecord: ISerializable, ITypedRecord<RCTuboRecord> {
		private static readonly GlobalObjectKey IdTubo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*P_sVsCj6tZcCQT_OJcAjZA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Tubo")]
		public ENTuboEntityRecord ssENTubo;


		public static implicit operator ENTuboEntityRecord(RCTuboRecord r) {
			return r.ssENTubo;
		}

		public static implicit operator RCTuboRecord(ENTuboEntityRecord r) {
			RCTuboRecord res = new RCTuboRecord(null);
			res.ssENTubo = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTubo.ChangedAttributes = value;
			}
			get {
				return ssENTubo.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTuboRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTubo = new ENTuboEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTubo.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTubo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTubo.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTubo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCTuboRecord r) {
			this = r;
		}


		public static bool operator == (RCTuboRecord a, RCTuboRecord b) {
			if (a.ssENTubo != b.ssENTubo) return false;
			return true;
		}

		public static bool operator != (RCTuboRecord a, RCTuboRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTuboRecord)) return false;
			return (this == (RCTuboRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTubo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCTuboRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTubo = new ENTuboEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENTubo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENTubo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENTubo = (ENTuboEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENTubo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTubo.InternalRecursiveSave();
		}


		public RCTuboRecord Duplicate() {
			RCTuboRecord t;
			t.ssENTubo = (ENTuboEntityRecord) this.ssENTubo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENTubo.ToXml(this, recordElem, "Tubo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "tubo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Tubo")) variable.Value = ssENTubo; else variable.Optimized = true;
				variable.SetFieldName("tubo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTubo.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTubo.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTubo) {
				return ssENTubo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTubo.FillFromOther((IRecord) other.AttributeGet(IdTubo));
		}
		public bool IsDefault() {
			RCTuboRecord defaultStruct = new RCTuboRecord(null);
			if (this.ssENTubo != defaultStruct.ssENTubo) return false;
			return true;
		}
	} // RCTuboRecord

	/// <summary>
	/// Structure <code>RCAbcRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAbcRecord: ISerializable, ITypedRecord<RCAbcRecord> {
		private static readonly GlobalObjectKey IdAbc = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4+zt7OjyrV19xur9aEA0WQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Abc")]
		public STAbcStructure ssSTAbc;


		public static implicit operator STAbcStructure(RCAbcRecord r) {
			return r.ssSTAbc;
		}

		public static implicit operator RCAbcRecord(STAbcStructure r) {
			RCAbcRecord res = new RCAbcRecord(null);
			res.ssSTAbc = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAbcRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAbc = new STAbcStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAbc.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAbc.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAbcRecord r) {
			this = r;
		}


		public static bool operator == (RCAbcRecord a, RCAbcRecord b) {
			if (a.ssSTAbc != b.ssSTAbc) return false;
			return true;
		}

		public static bool operator != (RCAbcRecord a, RCAbcRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAbcRecord)) return false;
			return (this == (RCAbcRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAbc.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAbcRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAbc = new STAbcStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAbc", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAbc' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAbc = (STAbcStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAbc.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAbc.InternalRecursiveSave();
		}


		public RCAbcRecord Duplicate() {
			RCAbcRecord t;
			t.ssSTAbc = (STAbcStructure) this.ssSTAbc.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAbc.ToXml(this, recordElem, "Abc", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "abc") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Abc")) variable.Value = ssSTAbc; else variable.Optimized = true;
				variable.SetFieldName("abc");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAbc) {
				return ssSTAbc;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAbc.FillFromOther((IRecord) other.AttributeGet(IdAbc));
		}
		public bool IsDefault() {
			RCAbcRecord defaultStruct = new RCAbcRecord(null);
			if (this.ssSTAbc != defaultStruct.ssSTAbc) return false;
			return true;
		}
	} // RCAbcRecord
}
