using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssExtTestK {

	public class CssExtTestK: IssExtTestK {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssNumberBegin">Número Inicial</param>
		/// <param name="ssNumberEnd">Número Final</param>
		/// <param name="ssNumberRandomic">Número randômico</param>
		public void MssGetRandonNumber(int ssNumberBegin, int ssNumberEnd, out int ssNumberRandomic) {
            Random random = new Random();
            ssNumberRandomic = (int) ((random.NextDouble() * (ssNumberEnd - ssNumberBegin)) + ssNumberBegin);
			// TODO: Write implementation for action
		} // MssGetRandonNumber


		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssNumberBegin">Número Inicial</param>
		/// <param name="ssNumberEnd">Número Final</param>
		/// <param name="ssNumberRandon">Número randômico resultante</param>
		public void MssGetRandomicNumber(int ssNumberBegin, int ssNumberEnd, out int ssNumberRandon) {
			ssNumberRandon = 0;
			// TODO: Write implementation for action
		} // MssGetRandomicNumber


		// /// <summary>
		// /// 
		// /// </summary>
		// public void MssGetTime(out DateTime ssTimee) {
		// 	// TODO: Write implementation for action
		// } // MssGetTime


	} // CssExtTestK

} // OutSystems.NssExtTestK

