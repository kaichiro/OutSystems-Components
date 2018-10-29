using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssExtTestK {

	/// <summary>
	/// RecordList type <code>RLTuboRecordList</code> that represents a record list of <code>Tubo</code>
	/// </summary>
	[Serializable()]
	public partial class RLTuboRecordList: GenericRecordList<RCTuboRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTuboRecord GetElementDefaultValue() {
			return new RCTuboRecord("");
		}

		public T[] ToArray<T>(Func<RCTuboRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTuboRecordList recordlist, Func<RCTuboRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTuboRecordList(RCTuboRecord[] array) {
			RLTuboRecordList result = new RLTuboRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTuboRecordList ToList<T>(T[] array, Func <T, RCTuboRecord> converter) {
			RLTuboRecordList result = new RLTuboRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTuboRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTuboRecord> converter) {
			RLTuboRecordList result = new RLTuboRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTuboRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTuboRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTuboRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTuboRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTuboRecord> NewList() {
			return new RLTuboRecordList();
		}


	} // RLTuboRecordList

	/// <summary>
	/// RecordList type <code>RLAbcRecordList</code> that represents a record list of <code>Abc</code>
	/// </summary>
	[Serializable()]
	public partial class RLAbcRecordList: GenericRecordList<RCAbcRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAbcRecord GetElementDefaultValue() {
			return new RCAbcRecord("");
		}

		public T[] ToArray<T>(Func<RCAbcRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAbcRecordList recordlist, Func<RCAbcRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAbcRecordList(RCAbcRecord[] array) {
			RLAbcRecordList result = new RLAbcRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAbcRecordList ToList<T>(T[] array, Func <T, RCAbcRecord> converter) {
			RLAbcRecordList result = new RLAbcRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAbcRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAbcRecord> converter) {
			RLAbcRecordList result = new RLAbcRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAbcRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAbcRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAbcRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAbcRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAbcRecord> NewList() {
			return new RLAbcRecordList();
		}


	} // RLAbcRecordList
}
