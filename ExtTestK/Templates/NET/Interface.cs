using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssExtTestK {

	public interface IssExtTestK {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssNumberBegin">Número Inicial</param>
		/// <param name="ssNumberEnd">Número Final</param>
		/// <param name="ssNumberRandomic">Número randômico</param>
		void MssGetRandonNumber(int ssNumberBegin, int ssNumberEnd, out int ssNumberRandomic);

	} // IssExtTestK

} // OutSystems.NssExtTestK
