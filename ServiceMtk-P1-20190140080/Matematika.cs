using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static ServiceMtk_P1_20190140080.IMatematika;

namespace ServiceMtk_P1_20190140080
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Tambah(int a, int b)
        {

            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }



        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {

            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }


        }
    }
}
        
    








