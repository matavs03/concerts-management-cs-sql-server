using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Domen;

namespace BrokerBazePodataka
{
    public class Broker
    {
        DbConnection connection;

        private static Broker instance;

        private Broker()
        {
            connection = new DbConnection();
        }

        public static Broker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Broker();
                }
                return instance;
            }
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        #region Žanr

        public int InsertZanr(Zanr zanr)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Žanr_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Naziv", zanr.Naziv);

            int noviId = (int)cmd.ExecuteScalar();
            zanr.Id = noviId;
            return noviId;
        }

        public void UpdateZanr(Zanr zanr)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Žanr_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", zanr.Id);
            cmd.Parameters.AddWithValue("@Naziv", zanr.Naziv);

            cmd.ExecuteNonQuery();
        }

        public void DeleteZanr(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Žanr_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Zanr GetZanrById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Žanr_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Zanr
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };
            }

            return null;
        }

        public List<Zanr> GetAllZanrovi()
        {
            
            List<Zanr> zanrovi = new List<Zanr>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Žanr_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Zanr zanr = new Zanr
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                zanrovi.Add(zanr);
            }
            
            return zanrovi;
        }

        #endregion

        #region Izvođač

        public int InsertIzvodjac(Izvodjac izvodjac)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Izvođač_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email", izvodjac.Email);

            int noviId = (int)cmd.ExecuteScalar();
            izvodjac.Id = noviId;
            return noviId;
        }

        public void UpdateIzvodjac(Izvodjac izvodjac)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Izvođač_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", izvodjac.Id);
            cmd.Parameters.AddWithValue("@Email", izvodjac.Email);

            cmd.ExecuteNonQuery();
        }

        public void DeleteIzvodjac(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Izvođač_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Izvodjac GetIzvodjacById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Izvođač_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Izvodjac
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1)
                };
            }

            return null;
        }

        public List<Izvodjac> GetAllIzvodjaci()
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Izvođač_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Izvodjac izvodjac = new Izvodjac
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1)
                };

                izvodjaci.Add(izvodjac);
            }

            return izvodjaci;
        }

        #endregion

        #region IzvođačŽanr

        public void InsertIzvodjacZanr(int izvodjacId, int zanrId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_IzvođačŽanr_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);
            cmd.Parameters.AddWithValue("@ŽanrId", zanrId);

            cmd.ExecuteNonQuery();
        }

        public void DeleteIzvodjacZanr(int izvodjacId, int zanrId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_IzvođačŽanr_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);
            cmd.Parameters.AddWithValue("@ŽanrId", zanrId);

            cmd.ExecuteNonQuery();
        }

        public void DeleteAllZanroviForIzvodjac(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_IzvođačŽanr_DeleteAllByIzvođačId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            cmd.ExecuteNonQuery();
        }

        public List<Zanr> GetZanroviByIzvodjacId(int izvodjacId)
        {
            List<Zanr> zanrovi = new List<Zanr>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_IzvođačŽanr_GetByIzvođačId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Zanr zanr = new Zanr
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                zanrovi.Add(zanr);
            }

            return zanrovi;
        }

        #endregion

        #region Muzičar

        public int InsertMuzicar(Muzicar muzicar)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Muzičar_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email", muzicar.Email);
            cmd.Parameters.AddWithValue("@Ime", muzicar.Ime);
            cmd.Parameters.AddWithValue("@Prezime", muzicar.Prezime);
            cmd.Parameters.AddWithValue("@Pol", muzicar.Pol.ToString());

            int noviId = (int)cmd.ExecuteScalar();
            muzicar.Id = noviId;
            return noviId;
        }

        public void UpdateMuzicar(Muzicar muzicar)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Muzičar_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", muzicar.Id);
            cmd.Parameters.AddWithValue("@Email", muzicar.Email);
            cmd.Parameters.AddWithValue("@Ime", muzicar.Ime);
            cmd.Parameters.AddWithValue("@Prezime", muzicar.Prezime);
            cmd.Parameters.AddWithValue("@Pol", muzicar.Pol.ToString());

            cmd.ExecuteNonQuery();
        }

        public void DeleteMuzicar(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Muzičar_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            cmd.ExecuteNonQuery();
        }

        public Muzicar GetMuzicarById(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Muzičar_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Muzicar muzicar = new Muzicar
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Ime = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    Pol = Enum.Parse<Pol>(reader.GetString(4).Trim())
                };

                return muzicar;
            }

            return null;
        }

        public List<Muzicar> GetAllMuzicari()
        {
            List<Muzicar> muzicari = new List<Muzicar>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Muzičar_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Muzicar muzicar = new Muzicar
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Ime = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    Pol = Enum.Parse<Pol>(reader.GetString(4).Trim())
                };

                muzicari.Add(muzicar);
            }

            return muzicari;
        }

        #endregion

        #region Bend

        public int InsertBend(Bend bend)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Bend_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email", bend.Email);
            cmd.Parameters.AddWithValue("@Naziv", bend.Naziv);
            cmd.Parameters.AddWithValue("@BrojČlanova", bend.BrojČlanova);

            int noviId = (int)cmd.ExecuteScalar();
            bend.Id = noviId;
            return noviId;
        }

        public void UpdateBend(Bend bend)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Bend_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", bend.Id);
            cmd.Parameters.AddWithValue("@Email", bend.Email);
            cmd.Parameters.AddWithValue("@Naziv", bend.Naziv);
            cmd.Parameters.AddWithValue("@BrojČlanova", bend.BrojČlanova);

            cmd.ExecuteNonQuery();
        }

        public void DeleteBend(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Bend_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            cmd.ExecuteNonQuery();
        }

        public Bend GetBendById(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Bend_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Bend bend = new Bend
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Naziv = reader.GetString(2),
                    BrojČlanova = reader.GetInt32(3)
                };

                return bend;
            }

            return null;
        }

        public List<Bend> GetAllBendovi()
        {
            List<Bend> bendovi = new List<Bend>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Bend_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bend bend = new Bend
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Naziv = reader.GetString(2),
                    BrojČlanova = reader.GetInt32(3)
                };

                bendovi.Add(bend);
            }

            return bendovi;
        }

        #endregion

        #region Grad

        public int InsertGrad(Grad grad)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Grad_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Naziv", grad.Naziv);

            int noviId = (int)cmd.ExecuteScalar();
            grad.Id = noviId;
            return noviId;
        }

        public void UpdateGrad(Grad grad)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Grad_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", grad.Id);
            cmd.Parameters.AddWithValue("@Naziv", grad.Naziv);

            cmd.ExecuteNonQuery();
        }

        public void DeleteGrad(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Grad_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Grad GetGradById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Grad_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Grad
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };
            }

            return null;
        }

        public List<Grad> GetAllGradovi()
        {
            List<Grad> gradovi = new List<Grad>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Grad_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Grad grad = new Grad
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                gradovi.Add(grad);
            }

            return gradovi;
        }

        #endregion

        #region Lokacija

        public int InsertLokacija(Lokacija lokacija)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Lokacija_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Naziv", lokacija.Naziv);
            cmd.Parameters.AddWithValue("@Adresa", lokacija.Adresa);
            cmd.Parameters.AddWithValue("@Kapacitet", lokacija.Kapacitet);
            cmd.Parameters.AddWithValue("@GradId", lokacija.grad.Id);

            int noviId = (int)cmd.ExecuteScalar();
            lokacija.id = noviId;

            return noviId;
        }

        public void UpdateLokacija(Lokacija lokacija)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Lokacija_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", lokacija.id);
            cmd.Parameters.AddWithValue("@Naziv", lokacija.Naziv);
            cmd.Parameters.AddWithValue("@Adresa", lokacija.Adresa);
            cmd.Parameters.AddWithValue("@Kapacitet", lokacija.Kapacitet);
            cmd.Parameters.AddWithValue("@GradId", lokacija.grad.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteLokacija(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Lokacija_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Lokacija GetLokacijaById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Lokacija_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Grad g = new Grad
                {
                    Id = reader.GetInt32(4),
                    Naziv = reader.GetString(5)
                };

                Lokacija lokacija = new Lokacija
                {
                    id = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Adresa = reader.GetString(2),
                    Kapacitet = reader.GetInt32(3),
                    grad = g
                };

                return lokacija;
            }

            return null;
        }

        public List<Lokacija> GetAllLokacije()
        {
            List<Lokacija> lokacije = new List<Lokacija>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sp_Lokacija_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Grad g = new Grad
                {
                    Id = reader.GetInt32(4),
                    Naziv = reader.GetString(5)
                };

                Lokacija lokacija = new Lokacija
                {
                    id = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Adresa = reader.GetString(2),
                    Kapacitet = reader.GetInt32(3),
                    grad = g
                };

                lokacije.Add(lokacija);
            }

            return lokacije;
        }

        #endregion
    }
}