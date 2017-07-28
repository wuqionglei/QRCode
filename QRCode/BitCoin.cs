using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NBitcoin;

namespace QRCode
{
    public class BitCoin
    {
        public void BitCoin()
        {
            Key privatekey = new Key();    //私钥
            BitcoinSecret secret = privatekey.GetBitcoinSecret(Network.Main);
            Console.WriteLine(" Bitcoin Secret: {0}", secret);

            PubKey publickey = privatekey.PubKey; //与私钥相对应得公钥
            Console.WriteLine("\n Public Key: {0}", publickey);

            KeyId publicKeyHash = publickey.Hash;   //得到公钥的 hash
            Console.WriteLine("\n Hashed Public Key: {0}", publicKeyHash);

            var mainNetAddress = publicKeyHash.GetAddress(Network.Main);
            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);
            Console.WriteLine(mainNetAddress);
            Console.WriteLine(publicKeyHash.ToString().Length + "+" + mainNetAddress.ToString().Length);

            //Console.WriteLine(testNetAddress);

            //BitcoinAddress address = publickey.GetAddress(Network.TestNet); //接收存放比特币的地址
            //Console.WriteLine("\n Address: {0}", address);

            //Script scriptPubKeyFromAddress = address.ScriptPubKey;
            //Console.WriteLine("\n Script PubKey From Address: {0}", scriptPubKeyFromAddress);

            //Script scriptPubKeyFromHash = hash.ScriptPubKey;
            //Console.WriteLine("\n Script PubKey From Hash: {0}", scriptPubKeyFromHash);

            //return Convert.ToString(scriptPubKeyFromAddress);

            var blockr = new BlockrTransactionRepository();
            Transaction transaction = blockr.Get("4ebf7f7ca0a5dafd10b9bd74d8cb93a6eb0831bcb637fec8e8aabf842f1c2688");
            Console.WriteLine(transaction.ToString());
        }
    }
}