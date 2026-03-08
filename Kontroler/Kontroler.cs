using BrokerBazePodataka;
using Domen;
using System;
using System.Collections.Generic;

namespace Kontroler
{
    public class Kontroler
    {
        private static Kontroler instance;

        private Kontroler()
        {
        }

        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                    instance = new Kontroler();
                return instance;
            }
        }

        private T ExecuteWithConnection<T>(Func<T> operation)
        {
            try
            {
                Broker.Instance.OpenConnection();
                return operation();
            }
            finally
            {
                Broker.Instance.CloseConnection();
            }
        }

        private void ExecuteWithConnection(Action operation)
        {
            try
            {
                Broker.Instance.OpenConnection();
                operation();
            }
            finally
            {
                Broker.Instance.CloseConnection();
            }
        }

        #region Zanr

        public int SacuvajZanr(Zanr zanr)
        {
            return ExecuteWithConnection(() => Broker.Instance.InsertZanr(zanr));
        }

        public void IzmeniZanr(Zanr zanr)
        {
            ExecuteWithConnection(() => Broker.Instance.UpdateZanr(zanr));
        }

        public void ObrisiZanr(int id)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteZanr(id));
        }

        public Zanr VratiZanrPoId(int id)
        {
            return ExecuteWithConnection(() => Broker.Instance.GetZanrById(id));
        }

        public List<Zanr> VratiSveZanrove()
        {
            return ExecuteWithConnection(() => Broker.Instance.GetAllZanrovi());
        }

        #endregion

        #region Izvodjac

        public int SacuvajIzvodjaca(Izvodjac izvodjac)
        {
            return ExecuteWithConnection(() => Broker.Instance.InsertIzvodjac(izvodjac));
        }

        public void IzmeniIzvodjaca(Izvodjac izvodjac)
        {
            ExecuteWithConnection(() => Broker.Instance.UpdateIzvodjac(izvodjac));
        }

        public void ObrisiIzvodjaca(int id)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteIzvodjac(id));
        }

        public Izvodjac VratiIzvodjacaPoId(int id)
        {
            return ExecuteWithConnection(() => Broker.Instance.GetIzvodjacById(id));
        }

        public List<Izvodjac> VratiSveIzvodjace()
        {
            return ExecuteWithConnection(() => Broker.Instance.GetAllIzvodjaci());
        }

        #endregion

        #region IzvodjacZanr

        public void SacuvajIzvodjacZanr(int izvodjacId, int zanrId)
        {
            ExecuteWithConnection(() => Broker.Instance.InsertIzvodjacZanr(izvodjacId, zanrId));
        }

        public void ObrisiIzvodjacZanr(int izvodjacId, int zanrId)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteIzvodjacZanr(izvodjacId, zanrId));
        }

        public void ObrisiSveZanroveZaIzvodjaca(int izvodjacId)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteAllZanroviForIzvodjac(izvodjacId));
        }

        public List<Zanr> VratiZanroveZaIzvodjaca(int izvodjacId)
        {
            return ExecuteWithConnection(() => Broker.Instance.GetZanroviByIzvodjacId(izvodjacId));
        }

        #endregion

        #region Muzicar

        public int SacuvajMuzicara(Muzicar muzicar)
        {
            return ExecuteWithConnection(() => Broker.Instance.InsertMuzicar(muzicar));
        }

        public void IzmeniMuzicara(Muzicar muzicar)
        {
            ExecuteWithConnection(() => Broker.Instance.UpdateMuzicar(muzicar));
        }

        public void ObrisiMuzicara(int izvodjacId)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteMuzicar(izvodjacId));
        }

        public Muzicar VratiMuzicaraPoId(int izvodjacId)
        {
            return ExecuteWithConnection(() => Broker.Instance.GetMuzicarById(izvodjacId));
        }

        public List<Muzicar> VratiSveMuzicare()
        {
            return ExecuteWithConnection(() => Broker.Instance.GetAllMuzicari());
        }

        #endregion

        #region Bend

        public int SacuvajBend(Bend bend)
        {
            return ExecuteWithConnection(() => Broker.Instance.InsertBend(bend));
        }

        public void IzmeniBend(Bend bend)
        {
            ExecuteWithConnection(() => Broker.Instance.UpdateBend(bend));
        }

        public void ObrisiBend(int izvodjacId)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteBend(izvodjacId));
        }

        public Bend VratiBendPoId(int izvodjacId)
        {
            return ExecuteWithConnection(() => Broker.Instance.GetBendById(izvodjacId));
        }

        public List<Bend> VratiSveBendove()
        {
            return ExecuteWithConnection(() => Broker.Instance.GetAllBendovi());
        }

        #endregion

        #region Grad

        public int SacuvajGrad(Grad grad)
        {
            return ExecuteWithConnection(() => Broker.Instance.InsertGrad(grad));
        }

        public void IzmeniGrad(Grad grad)
        {
            ExecuteWithConnection(() => Broker.Instance.UpdateGrad(grad));
        }

        public void ObrisiGrad(int id)
        {
            ExecuteWithConnection(() => Broker.Instance.DeleteGrad(id));
        }

        public Grad VratiGradPoId(int id)
        {
            return ExecuteWithConnection(() => Broker.Instance.GetGradById(id));
        }

        public List<Grad> VratiSveGradove()
        {
            return ExecuteWithConnection(() => Broker.Instance.GetAllGradovi());
        }

        #endregion
    }
}