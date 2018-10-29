using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;
//using OutSystems.NssExtTestK;

namespace OutSystems.NssExtTestK {

    public class CssExtTestK : IssExtTestK
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssNumberBegin">Número Inicial</param>
        /// <param name="ssNumberEnd">Número Final</param>
        /// <param name="ssNumberRandomic">Número randômico</param>
        public void MssGetRandonNumber(int ssNumberBegin, int ssNumberEnd, out int ssNumberRandomic)
        {
            ssNumberRandomic = _RandonNumber(ssNumberBegin, ssNumberEnd);
            // TODO: Write implementation for action
        } // MssGetRandonNumber

        int _RandonNumber(int a, int b)
        {
            Random random = new Random();
            return (int)((random.NextDouble() * (a - b)) + a);
        }

    }
} // OutSystems.NssExtTestK

