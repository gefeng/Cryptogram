using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cryptogram
{
    public interface IEncryptor
    {
        /// <summary>
        /// Bit wise xor calculation
        /// </summary>
        string Xor(string blockA, string blockB);

        /// <summary>
        /// Calculate pin block based on given format
        /// </summary>
        string CalPinBlock(string pan, string pin, PinBlockFormat format);

        /// <summary>
        /// Calculate pin from pin block
        /// </summary>
        string CalPin(string pan, string pinBlock, PinBlockFormat format);

        /// <summary>
        /// Triple des encryption
        /// </summary>
        string Encrypt3DES(string data, string key);

        /// <summary>
        /// Triple des decryption
        /// </summary>
        string Decrypt3DES(string encData, string key);

        /// <summary>
        /// Calculate key check value
        /// </summary>
        string CalKCV(string key);

        /// <summary>
        /// Calculate pvv
        /// </summary>
        string CalPVV(string pan, string pin, string pvki, string pvk);

        /// <summary>
        /// Calculate cvv
        /// </summary>
        string CalCVV(string pan, string expireDate, string serviceCode, string cvk);
    }

    public enum PinBlockFormat
    {
        ISO0,
        VISA3,
    }
}

