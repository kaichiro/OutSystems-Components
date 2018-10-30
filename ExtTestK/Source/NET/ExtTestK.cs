using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssExtTestK {

    public class CssExtTestK : IssExtTestK
    {

        private Utilitarios utl = new OutSystems.NssExtTestK.Utilitarios();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssNumberBegin">Número Inicial</param>
        /// <param name="ssNumberEnd">Número Final</param>
        /// <param name="ssNumberRandomic">Número randômico</param>
        public void MssGetRandonNumber(int ssNumberBegin, int ssNumberEnd, out int ssNumberRandomic)
        {
            ssNumberRandomic = Math.Abs(utl.__RandonNumber(ssNumberBegin, ssNumberEnd)); //_RandonNumber(ssNumberBegin, ssNumberEnd);
            // TODO: Write implementation for action
        } // MssGetRandonNumber

        //private int _RandonNumber(int a, int b)
        //{
        //    Random random = new Random();
        //    //return Math.Abs((int)((random.NextDouble() * (a - b)) + a));
        //    return Math.Abs(utl.__RandonNumber(a, b) );
        //}

    }
} // OutSystems.NssExtTestK

