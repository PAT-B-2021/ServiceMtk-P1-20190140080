using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140080
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Tambah(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Kurang(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Kali(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Bagi(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        Koordinat TKoordinat(Koordinat a, Koordinat b);
    }

    [DataContract]
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }

    public class Koordinat
    {
        private int _x, _y;
        [DataMember]
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
    

        
        
    

    

