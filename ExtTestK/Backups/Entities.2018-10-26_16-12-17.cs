using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtTestK {

	public sealed partial class ENTuboEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "Tubo";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "id", "Id"
				}
				, { "descricao", "Descricao"
				}
				, { "date", "Date"
				}
				, { "age", "Age"
				}
			};
		}
	} // ENTuboEntity

	/// <summary>
	/// Entity <code>ENTuboEntityRecord</code> that represents the Service Studio entity <code>Tubo</code>
	///  <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Tubo", "jlZbyQ8KwUqBG_KTtuExfA", "4xh1IncPgkeB0yJb1SUEQQ", 0, "Tubo", null)]
	[Serializable()]
	public partial struct ENTuboEntityRecord: ISerializable, ITypedRecord<ENTuboEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("4xh1IncPgkeB0yJb1SUEQQ*lPR0q73aOUyS39Rh5cdbZA");
		private static readonly GlobalObjectKey IdDescricao = GlobalObjectKey.Parse("4xh1IncPgkeB0yJb1SUEQQ*01L_m6idBkeMsnWMmHQnyg");
		private static readonly GlobalObjectKey IdDate = GlobalObjectKey.Parse("4xh1IncPgkeB0yJb1SUEQQ*pn9ukvvKCU+2yb2_tSAL0w");
		private static readonly GlobalObjectKey IdAge = GlobalObjectKey.Parse("4xh1IncPgkeB0yJb1SUEQQ*kDEICbwwEEijETqPxvQAdw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Id", 50, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("Id")]
		private string _ssId;
		public string ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(4, true);
					_ssId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Descricao", 50, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Descricao")]
		private string _ssDescricao;
		public string ssDescricao {
			get {
				return _ssDescricao;
			}
			set {
				if ((_ssDescricao!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssDescricao = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Date", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Date")]
		private DateTime _ssDate;
		public DateTime ssDate {
			get {
				return _ssDate;
			}
			set {
				if ((_ssDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Age", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Age")]
		private int _ssAge;
		public int ssAge {
			get {
				return _ssAge;
			}
			set {
				if ((_ssAge!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssAge = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENTuboEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssId = "";
			_ssDescricao = "";
			_ssDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssAge = 0;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssId = r.ReadText(index++, "Tubo.Id", "");
			ssDescricao = r.ReadText(index++, "Tubo.Descricao", "");
			ssDate = r.ReadDateTime(index++, "Tubo.Date", new DateTime(1900, 1, 1, 0, 0, 0));
			ssAge = r.ReadInteger(index++, "Tubo.Age", 0);
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENTuboEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTuboEntityRecord a, ENTuboEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssDescricao != b.ssDescricao) return false;
			if (a.ssDate != b.ssDate) return false;
			if (a.ssAge != b.ssAge) return false;
			return true;
		}

		public static bool operator != (ENTuboEntityRecord a, ENTuboEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTuboEntityRecord)) return false;
			return (this == (ENTuboEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssDescricao.GetHashCode()
				^ ssDate.GetHashCode()
				^ ssAge.GetHashCode()
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

		public ENTuboEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssId = "";
			_ssDescricao = "";
			_ssDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssAge = 0;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssId = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescricao", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescricao' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescricao = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAge", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAge' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAge = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENTuboEntityRecord Duplicate() {
			ENTuboEntityRecord t;
			t._ssId = this._ssId;
			t._ssDescricao = this._ssDescricao;
			t._ssDate = this._ssDate;
			t._ssAge = this._ssAge;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Descricao")) VarValue.AppendAttribute(recordElem, "Descricao", ssDescricao, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Descricao");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Date")) VarValue.AppendAttribute(recordElem, "Date", ssDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "Date");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Age")) VarValue.AppendAttribute(recordElem, "Age", ssAge, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Age");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
			} else if (head == "descricao") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Descricao")) variable.Value = ssDescricao; else variable.Optimized = true;
			} else if (head == "date") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Date")) variable.Value = ssDate; else variable.Optimized = true;
			} else if (head == "age") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Age")) variable.Value = ssAge; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdDescricao)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdAge)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdDescricao)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdAge)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdId) {
				return ssId;
			} else if (key == IdDescricao) {
				return ssDescricao;
			} else if (key == IdDate) {
				return ssDate;
			} else if (key == IdAge) {
				return ssAge;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssId = (string) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssDescricao = (string) other.AttributeGet(IdDescricao);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdDescricao);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescricao);
			ssDate = (DateTime) other.AttributeGet(IdDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDate);
			ssAge = (int) other.AttributeGet(IdAge);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdAge);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdAge);
		}
		public bool IsDefault() {
			ENTuboEntityRecord defaultStruct = new ENTuboEntityRecord(null);
			if (this.ssId != defaultStruct.ssId) return false;
			if (this.ssDescricao != defaultStruct.ssDescricao) return false;
			if (this.ssDate != defaultStruct.ssDate) return false;
			if (this.ssAge != defaultStruct.ssAge) return false;
			return true;
		}
	} // ENTuboEntityRecord

} // OutSystems.NssExtTestK
